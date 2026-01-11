function random(min, max) {
    return parseInt(Math.random() * (max - min)) + min;
}

window.correct = () => {
    const files = ["img_9855.jpg", "kawaii-cinnamoroll.gif"];

    document.getElementById("feedback-img").src = `./public/correct/${files[random(0, files.length)]}`;
    document.getElementById("correctAudio").play();
}

window.incorrect = () => {
    const files = ["cinnamoroll-dance.gif", "img_9850.jpg", "img_9854.jpg"];

    document.getElementById("feedback-img").src = `./public/incorrect/${files[random(0, files.length)]}`;
    document.getElementById("incorrectAudio").play();
}