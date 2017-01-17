function solve(params) {
    function getPoints(row, col) {
        return Math.pow(2, row) - col;
    }
    let input = params[0].split(' ');
    let rows = +input[0];
    let cols = +input[1];

    function getValue(params, row, col) {
        return params[row + 1][col];
    }

    row = rows - 1;
    col = cols - 1;
    let numberOfJumps = 0;
    let moves = 0;

    while(true) {

        if (row >= rows || col >= cols || row < 0 || col < 0) {
            console.log("Go go Horsy! Collected " + numberOfJumps + " weeds.");
            break;
        }
        moves = moves + 1;
        numberOfJumps = numberOfJumps + getPoints(row,col);

        var moves = moves[getValue(row, col) - 1]
    }
}

console.log(solve([
    '3 5',
    '54561',
    '43328',
    '52388']));