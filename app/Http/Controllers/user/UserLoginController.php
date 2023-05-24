<?php

namespace App\Http\Controllers\user;

use App\Http\Controllers\Controller;
use App\Models\User;
use Illuminate\Http\Request;

class UserLoginController extends Controller
{
    public function login(Request $request){
        $users = User::all();
        foreach ($users as $user){
        if($user->TC == $request->TC && $user->password == $request->password){
            return redirect()->route('user_homepage');
            }
        }
    }
}
