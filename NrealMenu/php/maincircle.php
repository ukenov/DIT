<?php

    $con = mysqli_connect('localhost', 'root', 'root', 'unitydit');
    //check that connection happened
    if (mysqli_connect_errno())
    {
        echo "1: Connection failed"; //error code #1 = connection failed
        exit();
    }
    $userid = $_POST["userid"];
    
    $insertmaincirclequery = "INSERT INTO maincircles(user_id) VALUES(" . $userid . ");";
    mysqli_query($con, $insertmaincirclequery) or die("4: Insert circle query failed");

    echo ("0");

?>
