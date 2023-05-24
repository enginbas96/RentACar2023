<?php


use App\Http\Controllers\admin\AdminController;
use App\Http\Controllers\admin\LoginController;
use App\Http\Controllers\admin\ProfileController;
use App\Http\Controllers\admin\UserController;

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

Route::get('/',[LoginController::class,'index'])->name('login');

/*Admin Pages*/
Route::get('/dashboard',[AdminController::class,'index'])->name('admin_dashboard');
Route::get('/profile',[ProfileController::class,'index'])->name('admin_profile');
Route::get('/users',[UserController::class,'index'])->name('admin_users');

/*User Pages*/
Route::get('/anasayfa',[HomePageController::class,'index'])->name('user_homepage');
Route::get('/iletişim',[ContactController::class,'index'])->name('user_contact');
Route::get('/araç-rezerve',[CarBookController::class,'index'])->name('user_car_book');
Route::get('/hakkında',[AboutController::class,'index'])->name('user_about');
Route::get('/araba-detayı',[CarsController::class,'carDetail'])->name('user_car_detail');
Route::get('/arabalar',[CarsController::class,'index'])->name('user_cars');
Route::post('/login-post',[UserLoginController::class,'login'])->name('user_login');
