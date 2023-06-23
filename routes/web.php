<?php


use App\Http\Controllers\admin\AdminController;
use App\Http\Controllers\admin\LoginController;
use App\Http\Controllers\admin\ProfileController;
use App\Http\Controllers\admin\UserController;
use App\Http\Controllers\admin\AdminCarsController;

use App\Http\Controllers\user\AboutController;
use App\Http\Controllers\user\CarBookController;
use App\Http\Controllers\user\CarsController;
use App\Http\Controllers\user\ContactController;
use App\Http\Controllers\user\HomePageController;
use App\Http\Controllers\user\UserLoginController;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "web" middleware group. Make something great!
|
*/



/*Admin Pages*/
Route::get('/', [LoginController::class, 'index'])->name('login');
Route::post('/admin-login-post', [LoginController::class, 'login'])->name('admin_login');
Route::get('/logout', [LoginController::class, 'logout'])->name('admin_logout');
Route::middleware(['auth'])->group(function () {
    Route::get('/dashboard', [AdminController::class, 'index'])->name('admin_dashboard');
    Route::get('/profile', [ProfileController::class, 'index'])->name('admin_profile');
    Route::get('/users', [UserController::class, 'index'])->name('admin_users');
    Route::get('/admin-cars', [AdminCarsController::class, 'index'])->name('admin_cars');
    Route::get('/user/banned/{id}', [UserController::class, 'banned'])->name('admin_user_banned');
    Route::get('/user/delete/{id}', [UserController::class, 'delete'])->name('admin_user_delete');
});

/*User Pages*/
Route::get('/user-login',[UserLoginController::class,'index'])->name('user_login_page');
Route::get('/anasayfa',[HomePageController::class,'index'])->name('user_homepage');
Route::get('/iletişim',[ContactController::class,'index'])->name('user_contact');
Route::get('/araç-rezerve/{id}',[CarBookController::class,'index'])->name('user_car_book');
Route::post('/araç-rezerve-post/{id}',[CarBookController::class,'carBook'])->name('user_car_book_post');
Route::get('/hakkında',[AboutController::class,'index'])->name('user_about');
Route::get('/araba-detayı/{id}',[CarsController::class,'carDetail'])->name('user_car_detail');
Route::get('/arabalar',[CarsController::class,'index'])->name('user_cars');
Route::post('/login-post',[UserLoginController::class,'login'])->name('user_login');
Route::post('/register',[UserLoginController::class,'register'])->name('user_register');
