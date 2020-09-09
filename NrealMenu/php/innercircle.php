<?php

    $con = mysqli_connect('localhost', 'root', 'root', 'unitydit');

    //check that connection happenedS
    if (mysqli_connect_errno())
    {
        echo "1: Connection failed"; //error code #1 = connection failed
        exit();
    }

    $maincircleid = $_POST["maincircleid"];
    $innerid = $_POST["innercirclefieldid"];

    $newinnercircle = "INSERT INTO innercircles (main_id, field_id) VALUES(" . $maincircleid . ", " . $innerid . ");";
    mysqli_query($con, $newinnercircle) or die("4: Insert user query failed");

    echo("0");

?>