<?php

namespace App\Http\Controllers\admin;

use App\Http\Controllers\Controller;
use App\Models\Car;
use Illuminate\Http\Request;

class AddCarController extends Controller
{
    public function index() {
        return view('admin.pages.addcars');
    }

    public function addCar(Request $request){
        $car = new Car();
        $gorsel = $request->file('gorsel');
        $path = public_path('img/user');
        $dosyaAdi = $gorsel->getClientOriginalName();
        $gorsel->move($path, $dosyaAdi);
        $car->plaka = $request->plaka;
        $car->marka = $request->marka;
        $car->model = $request->model;
        $car->yakit_turu = $request->yakit_turu;
        $car->renk = $request->renk;
        $car->hasar_kaydi = $request->hasar_kaydi;
        $car->km = $request->km;
        $car->vites = $request->vites;
        $car->koltuk_sayisi = $request->koltuk;
        $car->img_path ='img/user/'. $dosyaAdi;
        $car->isRent = 0;
        $car->save();
        return redirect()->route('add_car_page');

    }
}
