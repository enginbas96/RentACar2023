<?php

namespace App\Http\Controllers\admin;

use App\Models\Car;
use App\Models\CarStatus;
use App\Models\User;
use Illuminate\Http\Request;
use App\Http\Controllers\Controller;

class AdminController extends Controller
{
    public function index(){
        $username = auth()->check() ? auth()->user()->name : 'Oturum açmamış kullanıcı';
        $carsCount = Car::count();
        $rentCarCount = Car::where('isRent', 1)->count();
        $userCount = User::count();
        $rentCars = CarStatus::all();
        return view('admin.pages.dashboard', compact('username','carsCount','rentCarCount','userCount','rentCars'));
    }
}
