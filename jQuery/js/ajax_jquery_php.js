$(document).ready(function () {
  $('#form-new').submit(function (e) {
    e.preventDefault()
    var data = $(this).serialize()
    $.ajax({
      url: 'Php/server.php?mode=new',
      data: data

    })
  })

  $('#tally').load('Php/server.php?mode=tally')
  $('#server').load('Php/server.php?mode=build')
})
