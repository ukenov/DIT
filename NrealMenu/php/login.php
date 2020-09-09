<?php

$con = mysqli_connect('localhost', 'root', 'root', 'unitydit');

//check that connection happenedS
if (mysqli_connect_errno())
{
    echo "1: Connection failed"; //error code #1 = connection failed
    exit();
}

$username = $_POST["name"];
$password = $_POST["password"];

//check if name exists
$namecheckquery = "SELECT username, salt, hash FROM users WHERE username='" . $username . "';";

$namecheck = mysqli_query($con, $namecheckquery) or die("2: Name check query failed"); //error code #2 name check query failed

if(mysqli_num_rows($namecheck) != 1 ) 
{
    echo "5: Either no user with name, or more than one"; //error code #5 - number of name matching != 1
    exit();
}

//get login info from query 
$existinginfo = mysqli_fetch_assoc($namecheck);
$salt = $existinginfo["salt"];
$hash = $existinginfo["hash"];

$loginhash = crypt($password, $salt);
if($hash != $loginhash)
{
    echo "6: incorrect password"; //error code #6 - password does hash to match table
    exit();
}

$userid = "SELECT id FROM users WHERE username='" . $username . "';";
$useridquery = mysqli_query($con, $userid);
$fetchid = mysqli_fetch_assoc($useridquery);
$id = $fetchid["id"];

echo ("0");
echo ($id);

?>