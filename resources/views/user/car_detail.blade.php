<!DOCTYPE html>
<html lang="en">
<head>
    <title>Carbook - Free Bootstrap 4 Template by Colorlib</title>
    <style>
        .comments {
            width: 600px;
        }

        #comment-list {
            margin-top: 30px;
            border: 2px solid black;
        }

        #comment {
            padding: 10px;
            margin-bottom: 10px;
            height: 100px;
        }

        #comment-form {
            display: flex;
            flex-direction: column;
        }

        #comment-form input,
        #comment-form textarea {
            margin-bottom: 10px;
        }

        #comment-form button {
            width: 120px;
            align-self: flex-start;
            background-color: green;
            color: white;
        }
    </style>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link href="https://fonts.googleapis.com/css?family=Poppins:200,300,400,500,600,700,800&display=swap"
          rel="stylesheet">

    <link rel="stylesheet" href="{{asset('user/css/open-iconic-bootstrap.min.css')}}">
    <link rel="stylesheet" href="{{asset('user/css/animate.css')}}">

    <link rel="stylesheet" href="{{asset('user/css/owl.carousel.min.css')}}">
    <link rel="stylesheet" href="{{asset('user/css/owl.theme.default.min.css')}}">
    <link rel="stylesheet" href="{{asset('user/css/magnific-popup.css')}}">

    <link rel="stylesheet" href="{{asset('user/css/aos.css')}}">

    <link rel="stylesheet" href="{{asset('user/css/ionicons.min.css')}}">

    <link rel="stylesheet" href="{{asset('user/css/bootstrap-datepicker.css')}}">
    <link rel="stylesheet" href="{{asset('user/css/jquery.timepicker.css')}}">


    <link rel="stylesheet" href="{{asset('user/css/flaticon.css')}}">
    <link rel="stylesheet" href="{{asset('user/css/icomoon.css')}}">
    <link rel="stylesheet" href="{{asset('user/css/style.css')}}">
</head>
<body>

<nav class="navbar navbar-expand-lg navbar-dark ftco_navbar bg-dark ftco-navbar-light" id="ftco-navbar">
    <div class="container">
        <a class="navbar-brand" href="index.html">Car<span>Book</span></a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#ftco-nav"
                aria-controls="ftco-nav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="oi oi-menu"></span> Menu
        </button>

        <div class="collapse navbar-collapse" id="ftco-nav">
            <ul class="navbar-nav ml-auto">
                <li class="nav-item"><a href="index.html" class="nav-link">Home</a></li>
                <li class="nav-item"><a href="about.html" class="nav-link">About</a></li>
                <li class="nav-item"><a href="services.html" class="nav-link">Services</a></li>
                <li class="nav-item"><a href="pricing.html" class="nav-link">Pricing</a></li>
                <li class="nav-item active"><a href="car.html" class="nav-link">Cars</a></li>
                <li class="nav-item"><a href="blog.html" class="nav-link">Blog</a></li>
                <li class="nav-item"><a href="contact.html" class="nav-link">Contact</a></li>
            </ul>
        </div>
    </div>
</nav>
<!-- END nav -->

<section class="hero-wrap hero-wrap-2 js-fullheight" style="background-image: url({{asset('img/user/bg_3.jpg')}});"
         data-stellar-background-ratio="0.5">
    <div class="overlay"></div>
    <div class="container">
        <div class="row no-gutters slider-text js-fullheight align-items-end justify-content-start">
            <div class="col-md-9 ftco-animate pb-5">
                <p class="breadcrumbs"><span class="mr-2"><a href="index.html">Anasayfa<i
                                class="ion-ios-arrow-forward"></i></a></span> <span>Araç Detayı <i
                            class="ion-ios-arrow-forward"></i></span></p>
                <h1 class="mb-3 bread">Araç Detayı</h1>
            </div>
        </div>
    </div>
</section>


<section class="ftco-section ftco-car-details">
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-md-12">
                <div class="car-details">
                    <div class="img rounded" style="background-image: url({{asset('img/user/bg_1.jpg')}});"></div>
                    <div class="text text-center">
                        <span class="subheading">Cheverolet</span>
                        <h2>Mercedes Grand Sedan</h2>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md d-flex align-self-stretch ftco-animate">
                <div class="media block-6 services">
                    <div class="media-body py-md-4">
                        <div class="d-flex mb-3 align-items-center">
                            <div class="icon d-flex align-items-center justify-content-center"><span
                                    class="flaticon-dashboard"></span></div>
                            <div class="text">
                                <h3 class="heading mb-0 pl-3">
                                    Kilometre
                                    <span>40,000</span>
                                </h3>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md d-flex align-self-stretch ftco-animate">
                <div class="media block-6 services">
                    <div class="media-body py-md-4">
                        <div class="d-flex mb-3 align-items-center">
                            <div class="icon d-flex align-items-center justify-content-center"><span
                                    class="flaticon-pistons"></span></div>
                            <div class="text">
                                <h3 class="heading mb-0 pl-3">
                                    Vites
                                    <span>Otomatik</span>
                                </h3>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md d-flex align-self-stretch ftco-animate">
                <div class="media block-6 services">
                    <div class="media-body py-md-4">
                        <div class="d-flex mb-3 align-items-center">
                            <div class="icon d-flex align-items-center justify-content-center"><span
                                    class="flaticon-car-seat"></span></div>
                            <div class="text">
                                <h3 class="heading mb-0 pl-3">
                                    Koltuk Sayısı
                                    <span>5 Koltuk</span>
                                </h3>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md d-flex align-self-stretch ftco-animate">
                <div class="media block-6 services">
                    <div class="media-body py-md-4">
                        <div class="d-flex mb-3 align-items-center">
                            <div class="icon d-flex align-items-center justify-content-center"><span
                                    class="flaticon-backpack"></span></div>
                            <div class="text">
                                <h3 class="heading mb-0 pl-3">
                                    Model
                                    <span>2018</span>
                                </h3>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md d-flex align-self-stretch ftco-animate">
                <div class="media block-6 services">
                    <div class="media-body py-md-4">
                        <div class="d-flex mb-3 align-items-center">
                            <div class="icon d-flex align-items-center justify-content-center"><span
                                    class="flaticon-diesel"></span></div>
                            <div class="text">
                                <h3 class="heading mb-0 pl-3">
                                    Yakıt
                                    <span>Benzin</span>
                                </h3>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>
    </div>
</section>

<section class="ftco-section ftco-no-pt">
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-md-12 heading-section text-center ftco-animate mb-5">
                <span class="subheading">Araç Seç</span>
                <h2 class="mb-2">İlgili Araçlar</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <div class="car-wrap rounded ftco-animate">
                    <div class="img rounded d-flex align-items-end"
                         style="background-image: url({{asset('img/user/car-1.jpg')}});">
                    </div>
                    <div class="text">
                        <h2 class="mb-0"><a href="car-single.html">Mercedes Grand Sedan</a></h2>
                        <div class="d-flex mb-3">
                            <span class="cat">Cheverolet</span>
                            <p class="price ml-auto">$500 <span>/day</span></p>
                        </div>
                        <p class="d-flex mb-0 d-block"><a href="#" class="btn btn-primary py-2 mr-1">Rezerve et</a> <a
                                href="car-single.html" class="btn btn-secondary py-2 ml-1">Detaylar</a></p>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="car-wrap rounded ftco-animate">
                    <div class="img rounded d-flex align-items-end"
                         style="background-image: url({{asset('img/user/car-2.jpg')}});">
                    </div>
                    <div class="text">
                        <h2 class="mb-0"><a href="car-single.html">Range Rover</a></h2>
                        <div class="d-flex mb-3">
                            <span class="cat">Subaru</span>
                            <p class="price ml-auto">$500 <span>/day</span></p>
                        </div>
                        <p class="d-flex mb-0 d-block"><a href="#" class="btn btn-primary py-2 mr-1">Book now</a> <a
                                href="car-single.html" class="btn btn-secondary py-2 ml-1">Details</a></p>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="car-wrap rounded ftco-animate">
                    <div class="img rounded d-flex align-items-end"
                         style="background-image: url({{asset('img/user/car-3.jpg')}});">
                    </div>
                    <div class="text">
                        <h2 class="mb-0"><a href="car-single.html">Mercedes Grand Sedan</a></h2>
                        <div class="d-flex mb-3">
                            <span class="cat">Cheverolet</span>
                            <p class="price ml-auto">$500 <span>/day</span></p>
                        </div>
                        <p class="d-flex mb-0 d-block"><a href="#" class="btn btn-primary py-2 mr-1">Book now</a> <a
                                href="car-single.html" class="btn btn-secondary py-2 ml-1">Details</a></p>
                    </div>
                </div>
            </div>
        </div>
    </div>

</section>

<section class="ftco-section ftco-car-details">
    <div class="container">
        <div class="comments">
            <h2>Yorumlar</h2>
            <form id="comment-form">
                <textarea id="comment" placeholder="Yorumunuz" required></textarea>
                <button type="submit">Yorum Yap</button>
            </form>
            <div id="comment-list">
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Culpa ea earum fuga pariatur perspiciatis veniam, vitae. Modi nihil reiciendis similique temporibus? Ea fugiat minus necessitatibus nihil nisi nobis perspiciatis ut?</p>
            </div>
        </div>
    </div>

</section>


<footer class="ftco-footer ftco-bg-dark">
    <div class="container" style="text-align: center">
        <h2 class="ftco-heading-2"><a href="#" class="logo">Car<span>book</span></a></h2>

    </div>
</footer>


<!-- loader -->
<div id="ftco-loader" class="show fullscreen">
    <svg class="circular" width="48px" height="48px">
        <circle class="path-bg" cx="24" cy="24" r="22" fill="none" stroke-width="4" stroke="#eeeeee"/>
        <circle class="path" cx="24" cy="24" r="22" fill="none" stroke-width="4" stroke-miterlimit="10"
                stroke="#F96D00"/>
    </svg>
</div>


<script src="{{asset('user/js/jquery.min.js')}}"></script>
<script src="{{asset('user/js/jquery-migrate-3.0.1.min.js')}}"></script>
<script src="{{asset('user/js/popper.min.js')}}"></script>
<script src="{{asset('user/js/bootstrap.min.js')}}"></script>
<script src="{{asset('user/js/jquery.easing.1.3.js')}}"></script>
<script src="{{asset('user/js/jquery.waypoints.min.js')}}"></script>
<script src="{{asset('user/js/jquery.stellar.min.js')}}"></script>
<script src="{{asset('user/js/owl.carousel.min.js')}}"></script>
<script src="{{asset('user/js/jquery.magnific-popup.min.js')}}"></script>
<script src="{{asset('user/js/aos.js')}}"></script>
<script src="{{asset('user/js/jquery.animateNumber.min.js')}}"></script>
<script src="{{asset('user/js/bootstrap-datepicker.js')}}"></script>
<script src="{{asset('user/js/jquery.timepicker.min.js')}}"></script>
<script src="{{asset('user/js/scrollax.min.js')}}"></script>
<script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBVWaKrjvy3MaE7SQ74_uJiULgl1JY0H2s&sensor=false"></script>
<script src="{{asset('user/js/google-map.js')}}"></script>
<script src="{{asset('user/js/main.js')}}"></script>

</body>
</html>
