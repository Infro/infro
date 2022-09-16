function lemail(el) {
    var addr = "in"+"fro"+".j."+"z@g"+"mai"+"l.c"+"om";
    var hacky = "mai"+"lto"+":" + addr;
    var canvas = document.getElementById("myCanvas");
    var ctx = canvas.getContext("2d");
    ctx.font = "16px Arial";
    ctx.fillStyle = "#c13100";
    ctx.fillText(addr,0,17);
    canvas.addEventListener("click", function(event) {
        open(hacky);
    })
    console.log("ran");
};