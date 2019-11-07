var knight,
knightImage,
level = 1,
velocity = 1,
numBush = 4,
bush = [],
bushImage,
numTree = 2,
tree = [],
treeImage,
score = 0,
life = 3,
heartImage,
btnPauseImage,
btnRestartImage,
gameOver = "",
zombie = [],
numZombie = 3,
canvas;

function sprite(options) {
    var that = {},
    frameIndex = 0,
    tickCount = 0,
    tickPerFrame = options.tickPerFrame || 0,
    numberOfFrame = options.numberOfFrame || 1;
    that.context = options.context;
    that.w = options.w;
    that.h = options.h;
    that.img = options.img;
    that.x = options.x;
    that.y = options.y;
    that.scaleRatio = 1;
    that.update = function () {
        tickCount += 1;
        if (tickCount > tickPerFrame) {
        tickCount = 0;
        if (frameIndex < numberOfFrame - 1) {
        frameIndex += 1;
        } else {
        frameIndex = 0;
        }
        }
    };
    that.render = function () {
        that.context.drawImage(
            that.img,
            frameIndex * that.w / numberOfFrame,
            0,
            that.w / numberOfFrame,
            that.h,
            that.x,
            that.y,
            that.w / numberOfFrame,
            that.h
            );
    };
    that.getFrameWidth = function () {
        return that.w / numberOfFrame;
    }
    return that;
}

//get canvas
canvas = document.getElementById("cnv");
canvas.width = 1024;
canvas.height = 480;
//knight spite sheet
knightImage = new Image();
//knight sprite
knight = sprite({
    context: canvas.getContext("2d"),
    w: 1740,
    h: 210,
    img: knightImage,
    numberOfFrame: 10,
    tickPerFrame: 5,
    x: 0,
    y: canvas.height - 210
});

//bush
for (i = 0; i < numBush; i++) {
    spawnBush();
}
//tree
for (i = 0; i < numTree; i++) {
    spawnTree();
}
//zombie
for (i = 0; i < numZombie; i++) {
    spawnZombie();
}
gameLoop();
knightImage.src = "images/character/knight_run.png";

function gameLoop() {
    window.requestAnimationFrame(gameLoop);
    canvas.getContext("2d").clearRect(0, 0, canvas.width, canvas.height);
    //tree
    for (i = 0; i < tree.length; i++) {
        tree[i].update();
        tree[i].x += level * velocity / 2;
        tree[i].render();
        if (tree[i].x > canvas.width + 65) {
        tree[i].x = -80 - Math.floor(Math.random() * 1 + 1);
        }
    }
    //bush
    for (i = 0; i < bush.length; i++) {
        bush[i].update();
        bush[i].x += level * velocity / 2;
        bush[i].render();
        if (bush[i].x > canvas.width + 65) {
        bush[i].x = -80 - Math.floor(Math.random() * 3 + 1);
        }
    }
    //knight
    knight.update();
    knight.x -= level * velocity;
    if (knight.x < -128) {
        knight.x = canvas.width + Math.round(Math.random() *
        canvas.width);
    }
    knight.render();
    //hud
    drawHud();
    //zombie
    for (i = 0; i < zombie.length; i++) {
        zombie[i].update();
        zombie[i].x -= level * velocity;
        zombie[i].render();
        if (zombie[i].x < -128) {
            zombie[i].x = canvas.width + Math.random() * (canvas.width -
            zombie[i].getFrameWidth() * zombie[i].scaleRatio);
            life --;
            score ++;
        }
        if (score > level * 2) {
            level++;
        }
    }
}

function spawnBush() {
    var bushIndex,
    bushImage;
    bushImage = new Image();
    bushIndex = bush.length;
    bush[bushIndex] = sprite({
    context: canvas.getContext("2d"),
    img: bushImage,
    w: 0,
    h: 0,
    x: 0,
    y: 0,
    numberOfFrame: 1,
    tickPerFrame: 1
    });
    bush[bushIndex].x = 0 + Math.random() * (canvas.width -
    bush[bushIndex].getFrameWidth() * bush[bushIndex].scaleRatio);
    if (bushIndex == 0) {
    bush[bushIndex].w = 133;
    bush[bushIndex].h = 66;
    bush[bushIndex].y = canvas.height - 62;
    }
    if (bushIndex == 1) {
    bush[bushIndex].w = 73;
    bush[bushIndex].h = 47;
    bush[bushIndex].y = canvas.height - 45;
    }
    if (bushIndex == 2) {
    bush[bushIndex].w = 54;
    bush[bushIndex].h = 55;
    bush[bushIndex].y = canvas.height - 53;
    }
    if (bushIndex == 3) {
    bush[bushIndex].w = 53;
    bush[bushIndex].h = 76;
    bush[bushIndex].y = canvas.height - 74;
    }
    bush[bushIndex].scaleRatio = Math.random() * 0.5 + 0.5;
    bushImage.src = "images/bush/bush" + bushIndex + ".png";
}

function spawnTree() {
    var treeIndex,
    treeImage;
    treeImage = new Image();
    treeIndex = tree.length;
    tree[treeIndex] = sprite({
    context: canvas.getContext("2d"),
    img: treeImage,
    w: 0,
    h: 0,
    x: 0,
    y: 0,
    numberOfFrame: 1,
    tickPerFrame: 1
    });
    tree[treeIndex].x = 0 + Math.random() * (canvas.width -
    tree[treeIndex].getFrameWidth() * tree[treeIndex].scaleRatio);
    if (treeIndex == 0) {
    tree[treeIndex].w = 282;
    tree[treeIndex].h = 301;
    tree[treeIndex].y = canvas.height - 299;
    }
    if (treeIndex == 1) {
    tree[treeIndex].w = 282;
    tree[treeIndex].h = 301;
    tree[treeIndex].y = canvas.height - 299;
    }
    tree[treeIndex].scaleRatio = Math.random() * 0.5 + 0.5;
    treeImage.src = "images/tree/tree" + treeIndex + ".png";
}

function spawnZombie() {
    var zombieIndex,
    zombieImage;
    zombieImage = new Image();
    zombieIndex = zombie.length;
    zombie[zombieIndex] = sprite({
    context: canvas.getContext("2d"),
    w: 1740,
    h: 210,
    img: zombieImage,
    numberOfFrame: 10,
    tickPerFrame: 5
    });
    if ((zombieIndex % 2) == 1) {
    zombieImage.src = "images/character/zombie_female_run.png";
    } else {
    zombieImage.src = "images/character/zombie_run.png";
    }
    zombie[zombieIndex].x = canvas.width + Math.random() * (canvas.width -
    zombie[zombieIndex].getFrameWidth() * zombie[zombieIndex].scaleRatio);
    zombie[zombieIndex].y = canvas.height - 210;
    zombie[zombieIndex].scaleRatio = Math.random() * 0.5 + 0.5;
}

function drawHud() {
    var context = canvas.getContext("2d");
    //score
    context.font = "bold 20px Consolas";
    context.textAlign = "start";
    context.fillStyle = "white";
    context.fillText("Score: " + score, canvas.width - 275, 40);
    //level
    context.font = "bold 20px Consolas";
    context.textAlign = "start";
    context.fillStyle = "white";
    context.fillText("Level: " + level, canvas.width - 125, 40);
    //life
    context.font = "bold 20px Consolas";
    context.textAlign = "start";
    context.fillStyle = "white";
    context.fillText("Life: " + life, 30, 40);
    heartImage = new Image();
    heartImage.src = "images/heart/heart.png";
    for(i = 0; i < life; i++){
        if(i == 0){
            context.drawImage(heartImage, 105, 25);
        }
        if(i == 1){
            context.drawImage(heartImage, 150, 25);
        }
        if(i == 2){
            context.drawImage(heartImage, 195, 25);
        }
    }
    //button pause
    btnPauseImage = new Image();
    btnPauseImage.src = "images/button/btnPause.png";
    context.drawImage(btnPauseImage, canvas.width * 0.5 - 32, 25);
    //button restart
    if(life == 0){
        btnRestartImage = new Image();
        btnRestartImage.src = "images/button/btnRestart.png";
        context.drawImage(btnRestartImage, canvas.width * 0.5 - 60, canvas.height * 0.5);
        gameOver = "GAME OVER";
    }
    //gameover
    context.font = "bold 50px Consolas";
    context.textAlign = "center";
    context.fillStyle = "#193439";
    context.fillText(gameOver, context.canvas.width / 2,
    context.canvas.height / 2 - 32);
}

//Handler Click
canvas.addEventListener('click', (e) => {
    const pos = {
        x: e.clientX,
        y: e.clientY
    };
    // console.log(pos);
    // console.log(btnPauseImage.x);
    if(pos.x == knight.x){
        alert("Hit Knight!");
    }
    console.log(knight.x, pos.x);
});