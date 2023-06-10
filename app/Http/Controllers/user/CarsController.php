<?php

namespace App\Http\Controllers\user;

use App\Http\Controllers\Controller;
use App\Models\Car;
use Illuminate\Http\Request;

class CarsController extends Controller
{
    public function index(){
        $cars = Car::all();
        return view('user.cars', compact('cars'));
    }

    public function carDetail(){
        return view('user.car_detail');
    }
}
