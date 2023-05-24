<!DOCTYPE html>

<html lang="en" dir="ltr">
<head>
    <meta charset="UTF-8">
    <!--<title> Login and Registration Form in HTML & CSS | CodingLab </title>-->
    <link rel="stylesheet" href="{{asset("admin/css/style.css")}}">
    <!-- Fontawesome CDN Link -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
<div class="container">
    <input type="checkbox" id="flip">
    <div class="cover">
        <div class="front">
            <img src="{{asset('img/login/frontImg.jpg')}}" alt="">
            <div class="text">
                <span class="text-1">Every new friend is a <br> new adventure</span>
                <span class="text-2">Let's get connected</span>
            </div>
        </div>
        <div class="back">
            <img class="backImg" src="{{asset('img/login/backImg.jpg')}}" alt="">
            <div class="text">
                <span class="text-1">Complete miles of journey <br> with one step</span>
                <span class="text-2">Let's get started</span>
            </div>
        </div>
    </div>
    <div class="forms">
        <div class="form-content">
            <div class="login-form">
                <div class="title">Login</div>
                <form method="post" action="{{route('user_login')}}">
                    @csrf
                    <div class="input-boxes">
                        <div class="input-box">
                            <i class="fas fa-envelope"></i>
                            <input type="text" name="TC" placeholder="TC kimlik numaranızı giriniz...">
                        </div>
                        <div class="input-box">
                            <i class="fas fa-lock"></i>
                            <input type="password" name="password" placeholder="Şifrenizi giriniz...">
                        </div>
                        <div class="text"><a href="#">Forgot password?</a></div>
                        <div class="button input-box">
                            <input type="submit" value="Giriş">
                        </div>
                        <div class="text sign-up-text">Hesabınız yok mu? <label for="flip">Hemen kaydolun</label></div>
                    </div>
                </form>
            </div>
            <div class="signup-form">
                <div class="title">Kaydol</div>
                <form action="#">
                    <div class="input-boxes">
                        <div class="input-box">
                            <i class="fas fa-user"></i>
                            <input type="text" placeholder="İsminizi giriniz.." required>
                        </div>
                        <div class="input-box">
                            <i class="fas fa-envelope"></i>
                            <input type="text" placeholder="Soyisminizi giriniz.." required>
                        </div>
                        <div class="input-box">
                            <i class="fas fa-lock"></i>
                            <input type="password" placeholder="TC giriniz.." required>
                        </div>
                        <div class="input-box">
                            <i class="fas fa-lock"></i>
                            <input type="password" placeholder="Şifrenizi giriniz.." required>
                        </div>
                        <div class="input-box">
                            <i class="fas fa-lock"></i>
                            <input type="password" placeholder="Telefon numaranızı giriniz.." required>
                        </div>
                        <div class="button input-box">
                            <input type="submit" value="Kaydol">
                        </div>
                        <div class="text sign-up-text">Zaten hesabınız var mı? <label for="flip">Giriş yapın</label></div>
                    </div>
                </form>
            </div>
        </div>
    </div>
</div>
</body>
</html>
