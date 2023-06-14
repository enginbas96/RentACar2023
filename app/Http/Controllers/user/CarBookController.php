<?php

namespace App\Http\Controllers\user;

use App\Http\Controllers\Controller;
use App\Models\Car;
use App\Models\CarStatus;
use Carbon\Carbon;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Crypt;

class CarBookController extends Controller
{
    public function index($id)
    {
        $car = Car::find($id);
        return view('user.car_book', compact('car'));
    }

    public function carBook(Request $request, $id)
    {
        //$userId = Crypt::decrypt($userId);
        $userId = session('user_id');
        //dd($userId['id']);
        $now = Carbon::now('Europe/Istanbul')->format('Y-m-d H:i:s');
        $start_time = Carbon::parse($request->kiralanan_tarih . ' ' . $request->kiralanan_saat);
        $end_time = Carbon::parse($request->teslim_tarihi . ' ' . $request->teslim_saati);
        if ($start_time < $now) {
            return redirect()->route('user_car_book',$id)->withErrors('Kiralanan tarih şimdiki zamandan önce olamaz');
        } elseif ($end_time <= $start_time) {
            return redirect()->route('user_car_book',$id)->withErrors('Teslim tarihi kiralanan tarihten önce olamaz');
        } else{
            $carStatus = new CarStatus();
            $carStatus->arac_id = $id;
            $carStatus->musteri_id = $userId;
            $carStatus->start_time = $start_time;
            $carStatus->end_time = $end_time;
            $carStatus->save();
            return redirect()->route('user_cars');
        }


    }
}
