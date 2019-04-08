<!DOCTYPE html>
<html lang="en">

<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<meta http-equiv="X-UA-Compatible" content="ie=edge">
	<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css">
	<title>Youtube Channel Data</title>
</head>
<style>
	#content,
	#authorize-button,
	#signout-button {
		display: none;
	}
</style>

<body>
	<nav class="black">
		<div class="nav-wrapper">
			<div class="container">
				<a href="http://" class="brand-logo">Youtube Channel</a>
			</div>
		</div>
	</nav>
	<section>
		<div class="container">
			<p>Log In With Google</p>
			<button class="btn red" id="authorize-button">Log In</button>
			<button class="btn red" id="signout-button">Log Out</button>
		</div>
		<br>
		<div id="content">
			<div class="row">
				<div class="col s6">
					<form action="" id="channel-form">
						<div class="input-field">
							<input type="text" name="" id="channel-input" placeholder="Enter Channel Name...">
							<input type="submit" value="Get Channel Data" class="btn red lighten-2">
						</div>
					</form>
				</div>
				<div id="channel-data" class="col s6"></div>
				<div class="row" id="video-container"></div>
			</div>
		</div>
	</section>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>

	<script type="text/javascript">
		//Options
		var CLIENT_ID = '253983595200-0jjlfbmab00leol8h8qp52c60euot2cv.apps.googleusercontent.com';
		var DISCOVERY_DOCS = ["https://www.googleapis.com/discovery/v1/apis/youtube/v3/rest"];
		var SCOPES = 'https://www.googleapis.com/auth/youtube.readonly';

		var authorizeButton = document.getElementById('authorize-button');
		var signoutButton = document.getElementById('signout-button');
		var content = document.getElementById('content')
		var form = document.getElementById('channel-form')
		var input = document.getElementById('channel-input')
		var video = document.getElementById('video-container')


		form.addEventListener('submit', e => {
			e.preventDefault();
			const channel = input.value;
		});
		//Load auth2 library
		function handleClientLoad() {
			gapi.load('client:auth2', initClient);
		}

		function initClient() {
			gapi.client.init({
				discoveryDocs: DISCOVERY_DOCS,
				clientId: CLIENT_ID,
				scope: SCOPES
			}).then(function() {
				// Listen for sign-in state changes.
				gapi.auth2.getAuthInstance().isSignedIn.listen(updateSigninStatus);
				// Handle the initial sign-in state.
				updateSigninStatus(gapi.auth2.getAuthInstance().isSignedIn.get());
				authorizeButton.onclick = handleAuthClick;
				signoutButton.onclick = handleSignoutClick;
			});
		}

		function updateSigninStatus(isSignedIn) {
			if (isSignedIn) {
				authorizeButton.style.display = 'none';
				signoutButton.style.display = 'block';
				content.style.display = 'block';
				video.style.display = 'block';
				getChannel();
			} else {
				authorizeButton.style.display = 'block';
				signoutButton.style.display = 'none';
				content.style.display = 'none';
				video.style.display = 'none';
			}
		}

		function handleAuthClick() {
			gapi.auth2.getAuthInstance().signIn();
		}
		/**
		 *  Sign out the user upon button click.
		 */
		function handleSignoutClick() {
			gapi.auth2.getAuthInstance().signOut();
		}

		function showChannelInfo(data) {
			const channel = document.getElementById('channel-data');
			channel.innerHTML = data;
		}

		function requestVideoPlayList(playListId) {
			const requestOptions = {
				'part': 'snnipet',
				'maxResults': 10,
				'playlistId': 'PLBCF2DAC6FFB574DE'
			}

			gapi.client.youtube.playlistItems.list({
					"part": "snippet,contentDetails",
					"maxResults": 10,
					"playlistId": "PLBCF2DAC6FFB574DE"
				})
				.then(response => {
					console.log(response);
					const playListItems = response.result.items;
					if (playListItems) {
						var output = '<h4 class="center-align">Latest Videos</h4>'
						playListItems.forEach(element => {
							const videoId = element.snippet.resourceId.videoId;
							output += `
						<div class="col s3">
						<iframe width="100%" height="auto" src="https://www.youtube.com/embed/${videoId}" 
						frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; 
						picture-in-picture" allowfullscreen></iframe>
						</div>
						`;
						});
						video.innerHTML = output;
					} else {
						video.innerHTML = 'No Uploaded Videos';
					}
				}).catch((err) => {
					console.log('Error: ' + err)
				});			
		}

		function getChannel() {
			gapi.client.youtube.channels.list({
				'part': 'snippet,contentDetails,statistics',
				'id': 'UC_x5XG1OV2P6uZZ5FSM9Ttw'
			}).then(function(response) {
				console.log(response)
				const channel = response.result.items[0];
				const output = `
				<ul class="collection">
				<li class="collection-item">Title: ${channel.snippet.title}</li>
				<li class="collection-item">Published Date: ${channel.snippet.publishedAt}</li>
				<li class="collection-item">Id: ${channel.id}</li>
				<li class="collection-item">View: ${numberWithComas(channel.statistics.viewCount)}</li>
				<li class="collection-item">Video: ${numberWithComas(channel.statistics.videoCount)}</li>
				</ul>
				<p>${channel.snippet.description}</p>
				<hr>
				<a class="btn grey darken-2" target="_blank" href="https://youtube.com/${channel.snippet.customUrl}"> Visit channel</a>
				`;
				showChannelInfo(output);
				const playListId = channel.contentDetails.relatedPlaylists.uploads;
				requestVideoPlayList(playListId);
			}).catch(err => alert("No Channel By That Name"));
		}

		function numberWithComas(x) {
			return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
		}
	</script>

	<script async defer src="https://apis.google.com/js/api.js" onload="this.onload=function(){};handleClientLoad()" onreadystatechange="if (this.readyState === 'complete') this.onload()">
	</script>
</body>

</html>