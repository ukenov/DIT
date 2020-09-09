<?php

    $con = mysqli_connect('localhost', 'root', 'root', 'unitydit');
    //check that connection happened
    if (mysqli_connect_errno())
    {
        echo "1: Connection failed"; //error code #1 = connection failed
        exit();
    }
    $userid = $_POST["userid"];

    $checkformain = "SELECT user_id FROM maincircles WHERE user_id=" . $userid . ";";
    $namecheck = mysqli_query($con, $checkformain) or die("2: Main check query failed");
    
    if(mysqli_num_rows($namecheck) == 0 ) 
    {
        // Create new main circle if user doesn't have one and take it id
        $insertmaincirclequery = "INSERT INTO maincircles(user_id) VALUES(" . $userid . ");";
        mysqli_query($con, $insertmaincirclequery) or die("4: Insert circle query failed");
        $createmainid = "SELECT id FROM maincircles WHERE user_id=" . $userid . ";";
        $newmainid = mysqli_query($con, $createmainid) or die("4: Finding main circle id query failed");
        $fetchid = mysqli_fetch_assoc($newmainid);
        $id = $fetchid["id"];

        $insertfieldquery = "INSERT INTO circlefields (value, maincircle_id) VALUES('" . Greetings . "', " . $id . ");";
        mysqli_query($con, $insertfieldquery) or die("4: Insert user query failed");//error code #4 insert query failed
        $firstcirclefieldid = "SELECT id FROM circlefields WHERE maincircle_id=" . $id . " AND value='" . Greetings . "';";
        $firstcirclefieldidquery = mysqli_query($con, $firstcirclefieldid) or die("4: Finding field circle id query failed");
        $fetchfirstcirclefieldidquery = mysqli_fetch_assoc($firstcirclefieldidquery);
        $firstfieldid = $fetchfirstcirclefieldidquery["id"];

        $insertfieldquery = "INSERT INTO circlefields (value, maincircle_id) VALUES('" . Food . "', " . $id . ");";
        mysqli_query($con, $insertfieldquery) or die("4: Insert user query failed");//error code #4 insert query failed
        $secondcirclefieldid = "SELECT id FROM circlefields WHERE maincircle_id=" . $id . " AND value='" . Food . "';";
        $secondcirclefieldidquery = mysqli_query($con, $secondcirclefieldid) or die("4: Finding field circle id query failed");
        $fetchsecondcirclefieldidquery = mysqli_fetch_assoc($secondcirclefieldidquery);
        $secondfieldid = $fetchsecondcirclefieldidquery["id"];

        $insertfieldquery = "INSERT INTO circlefields (value, maincircle_id) VALUES('" . Shopping . "', " . $id . ");";
        mysqli_query($con, $insertfieldquery) or die("4: Insert user query failed");//error code #4 insert query failed
        $thirdcirclefieldid = "SELECT id FROM circlefields WHERE maincircle_id=" . $id . " AND value='" . Shopping . "';";
        $thirdcirclefieldidquery = mysqli_query($con, $thirdcirclefieldid) or die("4: Finding field circle id query failed");
        $fetchthirdcirclefieldidquery = mysqli_fetch_assoc($thirdcirclefieldidquery);
        $thirdfieldid = $fetchthirdcirclefieldidquery["id"];

        $insertfieldquery = "INSERT INTO circlefields (value, maincircle_id) VALUES('" . News . "', " . $id . ");";
        mysqli_query($con, $insertfieldquery) or die("4: Insert user query failed");//error code #4 insert query failed
        $fourthcirclefieldid = "SELECT id FROM circlefields WHERE maincircle_id=" . $id . " AND value='" . News . "';";
        $fourthcirclefieldidquery = mysqli_query($con, $fourthcirclefieldid) or die("4: Finding field circle id query failed");
        $fetchfourthcirclefieldidquery = mysqli_fetch_assoc($fourthcirclefieldidquery);
        $fourthfieldid = $fetchfourthcirclefieldidquery["id"];

        $insertfieldquery = "INSERT INTO circlefields (value, maincircle_id) VALUES('" . Sport . "', " . $id . ");";
        mysqli_query($con, $insertfieldquery) or die("4: Insert user query failed");//error code #4 insert query failed
        $fifthcirclefieldid = "SELECT id FROM circlefields WHERE maincircle_id=" . $id . " AND value='" . Sport . "';";
        $fifthcirclefieldidquery = mysqli_query($con, $fifthcirclefieldid) or die("4: Finding field circle id query failed");
        $fetchfifthcirclefieldidquery = mysqli_fetch_assoc($fifthcirclefieldidquery);
        $fifthfieldid = $fetchfifthcirclefieldidquery["id"];
        
        $insertfieldquery = "INSERT INTO circlefields (value, maincircle_id) VALUES('" . Reaction . "', " . $id . ");";
        mysqli_query($con, $insertfieldquery) or die("4: Insert user query failed");//error code #4 insert query failed
        $sixthcirclefieldid = "SELECT id FROM circlefields WHERE maincircle_id=" . $id . " AND value='" . Reaction . "';";
        $sixthcirclefieldidquery = mysqli_query($con, $sixthcirclefieldid) or die("4: Finding field circle id query failed");
        $fetchsixthcirclefieldidquery = mysqli_fetch_assoc($sixthcirclefieldidquery);
        $sixthfieldid = $fetchsixthcirclefieldidquery["id"];

        echo $firstfieldid . "\t" . $secondfieldid . "\t" . $thirdfieldid . "\t" . $fourthfieldid. "\t" . $fifthfieldid. "\t" . $sixthfieldid ."\t" . $id;
    }

?>