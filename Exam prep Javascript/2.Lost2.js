function solve(args) {

    function getRowsAndCols(str) {
        var parts = str.split(' ');
        return [parseInt(parts[0]), parseInt(parts[1])];
    }

    var rowsAndCols = getRowsAndCols(args[0]),
        field = args.slice(1).map(function (row) {
        return row.split(' ').map(Number);
        }),
        rows = rowsAndCols[0],
        cols = rowsAndCols[1],
        row = Math.ceil(rows / 2) - 1,
        col = Math.ceil(cols / 2) - 1;
    var boolMatrix = $.extend(true,[],field);
    console.log(boolMatrix);
    while(true) {
        break;
        var up = Math.round((field[row][col]).toString(2) % 10);
        var right = Math.round((field[row][col]).toString(2) / 10 % 10);
        var down = Math.round((field[row][col]).toString(2) / 100 % 10);
        var left = Math.round((field[row][col]).toString(2) / 1000);

        if (row >= rows || col >= cols || row < 0 || col < 0) {
            console.log("No rakiya, only JavaScript " + row + " " + col);
            break;
        }
        console.log(row + " row");
        console.log(col + " col");
        if (+up === 1) {
            row = row - 1;
            console.log(+up + " up");
        }
        if (+right === 1) {
            col = col + 1;
            console.log(+right + " right");
        }
        if (+down === 1) {
            row = row + 1;
            console.log(+down + " down");
        }
        if (+left === 1) {
            col = col - 1;
            console.log(+left + " left");
        }

        if (+up === 0 && +right === 0 && +down === 0 && +left === 0) {
            console.log("No JavaScript, only rakiya " + row + " " + col);
            break;
        }

        //else {
          //  console.log("error batka");
            //break;
        //}
    }
}


solve([
    '5 7',
    '9 5 3 11 9 5 3',
    '10 11 10 12 4 3 10',
    '10 10 12 7 13 6 10',
    '12 4 3 9 5 5 2',
    '13 5 4 6 13 5 6'
]);