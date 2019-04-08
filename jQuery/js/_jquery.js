/* Syntax: $(selector).action() */
// wait for the load of html
$(document).ready(function () {
  $('#hello').html('<h1>Hello world</h1>')
  // document.getElementById('hello').innerHTML = '<h1>Hello world!!</h1>'
  // Selector:
  // tag $("tag")
  // id $("#id")
  // class $(.class)
  // atributtes $("tag[attr = value]")
  // seudo selectors $(seudo[prop])

  /**
   * FILTERS OF SELECTION
   * .has: work over elements, which contain others elements 
   *       included in the has.
   * ex: $('selector').has('element'): return selector.element.
   * .not: work over elements which don't contain others elements
   *       not specific into the has.
   * .filter: work over elements which coincide with the search
   * ex: $(selector).filter(search) : return selector with search
   * .find: return all decendents of the element specificed
   * ex: $(selector).find(element) : return the elements decendents
   *                                 of the selector
   * .first, .last: return the first or last index
   * .eq(value): return the element coincides with the value
   */
  // CHAIN OF SELECTIONS
  $('div#text').find('p').eq(0).html('<b>Text changed in first paragraph</b>')
    .end().eq(1).html('Text changed in second paragraph').end().eq(2).text('Text no changed')
  // EXTRACT INFORMATION FROM ELEMENT
  // get html code
  console.log($('p#hello').html())
  // get text
  console.log($('p#hello').text())
  // get value from the input
  console.log($('input').val())

  // EXTRACT INFORMATION FROM ATTRIBUTE (GET)
  // $(selector).attr('attribute')
  // MODIFY INFORMATION IN A ATTRIBUTE (SET)
  // an attribute
  // $(selector).attr('attribute','value')
  // several attributes
  // $(selector).attr({
  //           'attribute1':'value1',
  //           'attribute2':'value2'
  // })

  /**FUNCTIONS CALLBACK
   * Methods mentioned above(html, text, vall, attr) have a callback funtion with two params:
   * index of the current element into the list of elements selected and
   * the original value
  */

  /**
   * TRAVERSING
  */

  // Ascendants:
  // .parent() : direct father
  // ex: $('span').parent().css('border', '2px solid blue')

  // .parents() : all ascendants
  // ex : $('span').parents().css('border', '2px solid blue')

  // .parentsUntil(selector) : all ascendants until the specific selector but it's not included
  // ex : $('span').parentsUntil('div').css('border', '2px solid blue')

  // .closest() the closest ascendant
  // ex : $('span').closest('ul').css('border', '2px solid blue')

  // BROTHERS
  // .siblings() : all brothers
  // $('input').siblings().css('border', '2px solid blue')
  // .next(), prev() : next and previous brother
  // .nextAll(), prevAll() : all next an previous brothers
  // .nextUntil(selector), .prevUntil(selector) : all next and previous brothers without including the specific selector

  // ADD ELEMENTS TO A SELECTION: DO NOT CREATE AN ELEMENT
  // .add(selectors) :
  // $('div').add('p').add('ul').css('border', '2px solid blue')

  // CLONE ELEMENTS
  // $('#hello').clone().appendTo('div#text')

  // CREATE ELEMENTS
  // var element = $('<p>Element created</p>')
  // $('div#text').append(element); or $(element).appendTo('div#text')

  // TRAVEL AND HANDLE ELEMENTS OF THE ARRAY
  // $.each(array/obj,function(index,element){}) 
  // : return the original array
  // $.map(array/obj,function(element,index){}) 
  // : return a new array based on the original array 
  // Object: {key:value}
  /* var obj = {'name':'Danny', 'lastname':'Hdez'}
  $.each(obj, function (key, value) { 
      alert(key+': '+value)
  }); */
  /*  var arr = [1,2,3,4,5]
   $.each(arr, function (indexInArray, valueOfElement) { 
      alert(indexInArray + '= '+valueOfElement)
    */
  // inArray(value,obj) : return the index of the value
  // $.merge(array1,array2) : join two arrays

  // JQUERY ARRAY
  // $(selector).each(function(){}) : go over the elements array of the selector
  /* ex: $('li').each(function(){
    alert($(this).text())
  }); */

  // .get(pos) : get the element in the position
  // .index() : get the position of the element

  // $.grep(selector,function(elem,index){})
  //  : search an element that meet with the criteria
  //    and return an array with the elements found
  /*  var filter = $.grep($('li'),function(ele,index){
     return index>0
   })
   $.each(filter,function(index,ele){
     alert(index+': '+ele.innerHTML)
   }); */
  /* METHODS OF TYPES
  $.isFunction(param)
  $.isEmptyObject(param)
  $.isPlainObject(param)
  $.isArray(param)
  $.isNumeric(param) */

  /**
   * METHODS OF DATE
   * $.now()
  */

  /**
   * METHODS OF STRINGS
   * $.trim()
   * 
   */

  /**
   * METHODS OF DATA
   * $.data(key,value) : add data, do not remove old data
     $.removeData(key) ; remove the specific data
   */

  // EFFECTS
  // $(selector).effect(speed) speed: 'slow'/'fast'/mls
  // jQuery.fx.speeds : store default speed

  /* $('input[type=button]').click(function () { 
    $('p').toggle('slow')
  }); */

  /**
   * toggle(): just work like that with jquery-1.8.min.js,
   *            with later versions, it's just to hide and show
   */

  $('#hide').toggle(

    function () {
      $('p').hide(1000)
      $(this).val('Show')
      $(this).next().css('background', '#9db3d4')
      $(this).next().attr('disabled', 'true')
    // this.value = 'Show'
    },
    function () {
      $('p').show(1000)
      $(this).next().css('background', '#102b53')
      document.getElementById('fade').disabled = false
      // $(this).val('Hide')
      this.value = 'Hide'
    }
  )

  $('#hello').toggle(
    function () {$(this).css({'color': '#9db3d4','background': '#102b53'});},
    function () {$(this).css({'color': 'blue','background': '#cce24e'});},
    function () {$(this).css({'color': 'purple','background': '#7e7c7a'});},
    function () {$(this).css({'color': 'turquoise','background': '#4c6e3e'})
    })

  /**
   * ANIMATIONS
   * $(selector).animate({params},speed,function_callback)
   */
  // .delay(ms)
  // $(selector).delay(ms) or $(selector).delay(ms).animate()
  $('#fade').click(function () {
    $('#div').animate({
      left: '250px',
      opacity: '0.5',
      height: '150px',
      width: '200px'
    },
      1000,
      function () {
        $(this).delay(1000).animate({
          opacity: '1',
          height: '100px',
          width: '100px'
        }, 1000)
      })
    $('#first').css({'font-family': 'Arial','color': '#4c6e3e'}).delay(2000)
      .hide(1000).delay(1000).show(1000)
  })

  // STOP ANIMATION
  // $(selector).stop(stopAll,gotoEnd)

  // OTHERS EVENTS
  // .on(): attaches one or more events handle for the selected element and child elements
  // $(selector).on(event,childSelector,data,function,map)
  $('#text').on('click', {nombre: 'Danny',apellido: 'Hdez'}
    , function (e) {
      alert(e.data.nombre + ' ' + e.data.apellido)
    })

/*   $('#first').on({
    mouseover: function () {
      $('body').css('background-color', 'lightgray')
    },
    mouseout: function () {
      $('body').css('background-color', 'lightblue')
    }
  }) */
// .one() : execute once for every selected element
// $(selector).one(event,data,function)
//.trigger(): simulate the execution of the event
})
