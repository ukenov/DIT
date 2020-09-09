<?php

    $con = mysqli_connect('localhost', 'root', 'root', 'unitydit');

    //check that connection happenedS
    if (mysqli_connect_errno())
    {
        echo "1: Connection failed"; //error code #1 = connection failed
        exit();
    }

    $innerid = $_POST["innercircleid"];

    $newinnercircle = "INSERT INTO circlefields (innercircle_id) VALUES (" . $innerid . ");"
    mysqli_query($con, $newinnercircle) or die("4: Insert user query failed");

    $insertfieldquery = "INSERT INTO circlefields (value) VALUES('" . $first . "');";
    mysqli_query($con, $insertfieldquery) or die("4: Insert user query failed");//error code #4 insert query failed

    $insertfieldquery = "INSERT INTO circlefields (value) VALUES('" . $second . "');";
    mysqli_query($con, $insertfieldquery) or die("4: Insert user query failed");//error code #4 insert query failed

    $insertfieldquery = "INSERT INTO circlefields (value) VALUES('" . $third . "');";
    mysqli_query($con, $insertfieldquery) or die("4: Insert user query failed");//error code #4 insert query failed

    $insertfieldquery = "INSERT INTO circlefields (value) VALUES('" . $fourth . "');";
    mysqli_query($con, $insertfieldquery) or die("4: Insert user query failed");//error code #4 insert query failed

    $insertfieldquery = "INSERT INTO circlefields (value) VALUES('" . $fifth . "');";
    mysqli_query($con, $insertfieldquery) or die("4: Insert user query failed");//error code #4 insert query failed

    $insertfieldquery = "INSERT INTO circlefields (value) VALUES('" . $sixth . "');";
    mysqli_query($con, $insertfieldquery) or die("4: Insert user query failed");//error code #4 insert query failed

    echo("0");

?>