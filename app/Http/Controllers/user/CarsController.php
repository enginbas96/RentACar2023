<?php

namespace App\Http\Controllers\user;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;

class CarsController extends Controller
{
    public function index(){
        return view('user.cars');
    }

    public function carDetail(){
        return view('user.car_detail');
    }
}
