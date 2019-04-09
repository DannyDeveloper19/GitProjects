var tempMode = 1
function getWeather (latitude, longitude) {
  var apiURI = 'http://api.openweathermap.org/data/2.5/weather?lat=' + latitude + '&lon=' + longitude + '&appid=06170c100199dbae1e223cc3dfad960b'

  $.ajax({
    url: apiURI,
    dataType: 'json',
    type: 'GET',
    async: 'false',
    success: function (resp) {
      if (resp.name) {
        $('#ajaxloader').hide();
        $('#city-text').html(resp.name + ', ' + resp.sys.country)
      }
      if (resp.main.temp) {
        var fahr = (resp.main.temp * 9 / 5) - 459.67
        var cels = (resp.main.temp - 273.15)
        if (cels > 24) {
          $('#temp-text').css('color', 'red')
        } else if (cels < 18) {
          $('#temp-text').css('color', 'blue')
        }
        $('#temp-text').html((tempMode === 1 ? fahr.toFixed(0) + ' F&deg' : cels.toFixed(0) + ' C&deg'))
      }
      if (resp.weather) {
        var imgURL = 'http://openweathermap.org/img/w/' + resp.weather[0].icon + '.png'
        console.log(imgURL)
        $('#weatherImg').attr('src', imgURL)
        if (resp.main)
          $('#weather-text').html(resp.weather[0].description + '<br/> Humid: ' + resp.main.humidity + '%')
        else
          $('#weather-text').html(resp.weather[0].description)
      }
      if (resp.main.temp_min && resp.main.temp_max) {
        var fahrmin = (resp.main.temp_min * 9 / 5) - 459.67
        var celsmin = (resp.main.temp_min - 273.15)
        var fahrmax = (resp.main.temp_max * 9 / 5) - 459.67
        var celsmax = (resp.main.temp_max - 273.15)
        var temparture = (tempMode === 1) ? 'Min: ' + fahrmin.toFixed(0) + ' F&deg<br/>' : 'Min: ' + celsmin.toFixed(0) + ' C&deg <br/>'
        temparture += (tempMode === 1) ? 'Max: ' + fahrmax.toFixed(0) + ' F&deg' : 'Max: ' + celsmax.toFixed(0) + ' C&deg'
        $('#temp_min').html(temparture)
     }     
    },
    error: function (resp) {
      alert('Error: ' + e)
      clearInterval(updateinter)
    }
  })
}
function getLocation () {
  if ('geolocation' in navigator) {
    navigator.geolocation.getCurrentPosition(function (position) {
      getWeather(position.coords.latitude, position.coords.longitude)
    })
  } else {
    alert('geolocation not available' + e)
    clearInterval(updateinter)
  }
}
function getLocations (city) {
  $.getJSON('https://maps.googleapis.com/maps/api/geocode/json?address=' + encodeURIComponent(city), function (val) {
    if (val.results.length) {
      var location = val.results[0].geometry.location
      lat = location.lat
      lng = location.lng
    }
    $('#output').html('Latitude: ' + lat + ' Longitude: ' + lng)
    getWeather(lat, lng)
  })
}
$(document).ready(function () {
  var lat = 0
  var lng = 0
  var text = ''
  var city = $('#place').val()
  if (city == '') {
    //$('#city-text').html('loading...')
    getLocation()
  }
  $('#place').keydown(function (e) {
    var city = $('#place').val()
    if (e.which == '13') {
      getLocations(city)
    }
  })
})
/* var i = 0
 var updateinter = setInterval(function () {
   console.log('iteration# ' + i++)
   if ('geolocation' in navigator) {
     navigator.geolocation.getCurrentPosition(function (position) {
       getWeather(position.coords.latitude, position.coords.longitude)
     })
   } else {
     alert('geolocation not available' + e)
   }
 }, 300000)

 getLocation() */

/* function getLocations(city) {
  $.getJSON('https://maps.googleapis.com/maps/api/geocode/json?address=' + encodeURIComponent(city), function (val) {
      if (val.results.length) {
        var location = val.results[0].geometry.location
        lat = location.lat
        lng = location.lng
      }
      $('#output').html('Latitude: ' + lat + ' Longitude: ' + lng)
      getWeather(lat, lng)
    })
} */
/*  $('#tempMode').on('click', function () {
        if (this.checked) {
          $('#temp-text').html(cels.toFixed(1) + ' C&deg')
          console.log('checked')
        } else
          $('#temp-text').html(fahr.toFixed(0) + ' F&deg')
      })
      console.log(apiURI)
      console.log(resp.name) */
/* if (resp.wind) {
 var knots = resp.wind.speed * 1.9438445
 $('#wind-text').html(knots.toFixed(1) + ' Knots')
      } */
