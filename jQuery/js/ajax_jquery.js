$(document).ready(function () {
  $('#sendAjax').click(function () {
    var name = $('#name').val()
    var last = $('#lastname').val()
    var params = {
      'nombre': name,
      'apellido': last
    }
    // .ajax(url,data,succes:function,...): used to perform an Ajax request
    $.ajax({
      url: 'Php/server.php',
      data: params,
      success: function (answer) {
        $('#info').text(answer + 'with method $.ajax')
      },
      error: function (xhr, status) {
        alert('Error')
      },
      complete: function (xhr, status) {
        alert('Work')
      }

    })
  })
  $('#sendGet').click(function () {
    var name = $('#name').val()
    var last = $('#lastname').val()
    var params = {
      'nombre': name,
      'apellido': last
    }
    // $.get():
    $.get('Php/server.php',
      params,
      function (answer) {
        $('#info').text(answer + ' with method $.get')
      })
  })
  $('#sendGetMessage').click(function () {
    $.get('Php/server.php',
      function () {
        alert(' Successful!!')
      }).done(function () {
      alert('Successfull again')
    }).fail(function () {
      alert('Error')
    }).always(function (answer) {
      alert(answer)
    })
  })
  $('#sendPost').click(function () {
    $.post('Php/server.php', {'nombre': 'Danny','apellido': 'Simons'},
      function (data, status) {
        alert(data + ' ' + status)
      }
    )
  })
  $('#getScript').click(function () {
    $.getScript('js/script.js',
      function () {
        inScript()
      })
  })
  $('#getJSON').click(function () {
    $.getJSON('JSON/text.json', function (data) {
      $.each(data, function (key, value) {
        alert(key + ' ' + value)
      })
    })
  })
  $('#load').click(function () {
    $('#info').load('Php/server.php', function () {
      alert('server.php loaded')
    })
  })
})
