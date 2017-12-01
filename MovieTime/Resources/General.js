function showRegister() {
    document.getElementById("formLogin").style.display = "none";
    document.getElementById("formRegister").style.display = "block";
    $("#formRegister").addClass("animated flipInY");
}

function showLogin() {
    document.getElementById("formRegister").style.display = "none";
    document.getElementById("formLogin").style.display = "block";
    $("#formLogin").addClass("animated flipInY");
    
}

function showConfirmation() {
    document.getElementById("formEmail").style.display = "none";
    document.getElementById("formConfirmation").style.display = "block";
    document.getElementById("btnSend").style.visibility = "hidden";
    bodymovin.loadAnimation({
        container: document.getElementById("divAnimation"), // Required
        path: "/Resources/Animations/sent-animation.json", // Required
        renderer: "svg", // Required
        loop: true, // Optional
        autoplay: true, // Optional
        name: "Sent email", // Name for future reference. Optional.
    })
}

function showRequest() {
    document.getElementById("formConfirmation").style.display = "none";
    document.getElementById("formEmail").style.display = "block";
    document.getElementById("btnSend").style.visibility = "visible";
    bodymovin.destroy()
}

$(function () {
    $("#movie-row").niceScroll({
        cursorcolor: "#d8d8d8",
    });    
});

//function showActionsPanel() {    
//    document.getElementById("box-actions").style.display = "block";    
//}

//function hideActionsPanel() {
//    document.getElementById("box-actions").style.display = "none";
//}


$(document).ready(function () {
    $("#box-parent").hover(function () {
        $(this).css("display", "none");
    }, function () {
        $(this).css("display", "block");
    });
});


