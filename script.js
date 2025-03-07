document.addEventListener("DOMContentLoaded", function () {
    let video = document.getElementById("backgroundVideo");
    let button = document.getElementById("toggleButton");

    button.addEventListener("click", function () {
        if (video.paused) {
            video.play();
        } else {
            video.pause();
        }
    });
});

document.addEventListener("keydown", function(event) {
    if (event.key === "h" || event.key === "H") {
        let container = document.getElementById("registerContainer");
        container.style.display = (container.style.display === "none") ? "block" : "none";
    }
});

document.getElementById("toggleButton").addEventListener("click", function() {
    let container = document.getElementById("registerContainer");
    container.style.display = (container.style.display === "none") ? "block" : "none";
});

function updateClock() {
    let now = new Date();
    let timeString = now.toLocaleTimeString();
    document.getElementById("clock").textContent = timeString;
}
setInterval(updateClock, 1000);
updateClock();