<?php session_start(); ?>
<!DOCTYPE html>
<?php $mysqli = new mysqli("localhost", "root", "", "prirodnakozmetika");
if($mysqli === false){
    die("ERROR: Could not connect. " . mysqli_connect_error());
}

