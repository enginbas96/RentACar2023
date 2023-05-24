<?php

namespace App\Http\Controllers\user;

use App\Http\Controllers\Controller;
use App\Models\User;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Hash;

class UserLoginController extends Controller
{
    public function login(Request $request){
        $users = User::where('TC',$request->TC)->where('password',$request->password)->first();

        if($users){
            return redirect()->route('user_homepage');
            }
        else{
            return redirect()->route('login');
        }

    }
}
