(function () {
    window.helper = {
        colapsarNav: function () {
            if ($("body").hasClass("content-wrapper")) {
                $("body").trigger("resize");
                $(".sidebar-nav, .slimScrollDiv").css("overflow", "hidden").parent().css("overflow", "visible");
                $("body").removeClass("content-wrapper");
                $(".open-close i").addClass("icon-arrow-left-circle");
                $(".logo span").show();
            }
            else {
                $("body").trigger("resize");
                $(".sidebar-nav, .slimScrollDiv").css("overflow-x", "visible").parent().css("overflow", "visible");
                $("body").addClass("content-wrapper");
                $(".open-close i").removeClass("icon-arrow-left-circle");
                $(".logo span").hide();
            }
        },
        iniciarWizard: function (id) {
            $(id).wizard();
        },
        navLink: function () {
            $('.visited li').removeClass('active');
            var $parent = $(this).parent();
            if (!$parent.hasClass('active')) {
                $parent.addClass('active');
            }
        },
        iniciarPixel: function () {
            $(window).bind("load resize", function () {
                topOffset = 60;
                width = (this.window.innerWidth > 0) ? this.window.innerWidth : this.screen.width;
                if (width < 768) {
                    $('div.navbar-collapse').addClass('collapse');
                    topOffset = 100;
                }
                else {
                    $('div.navbar-collapse').removeClass('collapse');
                }
                height = ((this.window.innerHeight > 0) ? this.window.innerHeight : this.screen.height) - 1;
                height = height - topOffset;
                if (height < 1) height = 1;
                if (height > topOffset) {
                    $("#page-wrapper").css("min-height", (height) + "px");
                }
            });
            var url = window.location;
            var element = $('ul.nav a').filter(function () {
                return this.href == url || url.href.indexOf(this.href) == 0;
            }).addClass('active').parent().parent().addClass('in').parent();
            if (element.is('li')) {
                element.addClass('active');
            }
        },
        next: function (id) {
            $(id).wizard('next');
        },
        back: function (id) {
            $(id).wizard('back');
        },
        reset: function (id) {
            $(id).wizard('reset');
        },
        finish: function (id) {
            $(id).wizard('done');
        },
        exito: function (mensaje) {
            $.toast().reset('all');
            $.toast({
                heading: '¡Éxito!',
                text: mensaje,
                position: 'top-right',
                loaderBg: '#52BE80',
                icon: 'info',
                hideAfter: 8000,
                stack: 6
            });
        },
        error: function (mensaje) {
            $.toast().reset('all');
            $.toast({
                heading: 'Error',
                text: mensaje,
                position: 'top-right',
                loaderBg: '#ff6849',
                icon: 'error',
                hideAfter: 8000
            });
        },
        cargando: function () {
            $.toast().reset('all');
            $.toast({
                heading: 'Procesando',
                text: 'Se esta procesando información, espera un momento',
                position: 'top-right',
                textAlign: 'center',
                hideAfter: 15000
            });
        },
        reset: function () {
            $.toast().reset('all');
        },
        ciclo: function () {
            dotnet.invokeMethodAsync('monitorSesion');
        },
        monitorSesion: function (dotNetHelper) {
            dotnet = dotNetHelper;
            timer = setInterval(helper.ciclo, 6000)
        },
        detenerMonitor: function () {
            clearInterval(timer)
        }
    }
})()

var timer = null;
var dotnet = null;