
(function ($) {

    'use strict';

    // Selectize
    $('#select-category, #select-lang,#select-country').selectize({
        create: true,
        sortField: {
            field: 'text',
            direction: 'asc'
        },
        dropdownParent: 'body'
    });


    // Blog Search

    $(document).ready(function () {
        //Search
        $(document).on("keyup", "#input-search", function () {
            let search = $(this).val().trim();
            $("#searchList li").slice(1).remove();
            if (search.length > 0) {
                $.ajax({
                    url: "/Blog/Search?search=" + search,
                    type: "Get",
                    success: function (res) {
                        $("#searchList").append(res);
                    }
                })
            }

        })
    })





    //file upload

    let upload = document.getElementById("upload")
    let div = document.getElementById("div")

    div.onclick = function () {
        this.nextElementSibling.click();
    }

    div.nextElementSibling.onchange = function (ev) {
        const reader = new FileReader();
            reader.onloadend = function (ev) {
                let img = document.createElement("img");
                img.setAttribute("src", ev.target.result);
               div.appendChild(img); 
               
            }
        reader.readAsDataURL(ev.target.files[0]);
        div.innerHTML=""
       
    }


    // Checkbox all select
    $("#customCheckAll").click(function() {
        $(".all-select").prop('checked', $(this).prop('checked'));
    });

    // Nice Select
    $('.nice-select').niceSelect();

    // Contact
    $('#contact-form').submit(function() {
        var action = $(this).attr('action');

        $("#message").slideUp(750, function() {
            $('#message').hide();

            $('#submit')
                .before('')
                .attr('disabled', 'disabled');

            $.post(action, {
                    name: $('#name').val(),
                    email: $('#email').val(),
                    comments: $('#comments').val(),
                },
                function(data) {
                    document.getElementById('message').innerHTML = data;
                    $('#message').slideDown('slow');
                    $('#cform img.contact-loader').fadeOut('slow', function() {
                        $(this).remove()
                    });
                    $('#submit').removeAttr('disabled');
                    if (data.match('success') != null) $('#cform').slideUp('slow');
                }
            );

        });
        return false;
    });

})(jQuery)