function solve(args) {
    'use strict';
    var sizes = args[0].split(' ').map(Number),
        field = args.slice(1).map(function (row) {
            return row.split(' ').map(Number);
        }),
        rows = sizes[0],
        cols = sizes[1],
        row = Math.ceil(rows / 2) - 1;
        col = Math.ceil(cols / 2) - 1;
        used = {},

        directions = [{}, {
            row: -2,
            col: 1
        }, {
            row: -1,
            col: 2
        }, {
            row: 1,
            col: 2
        }, {
            row: 2,
            col: 1
        }, {
            row: 2,
            col: -1
        }, {
            row: 1,
            col: -2
        }, {
            row: -1,
            col: -2
        }, {
            row: -2,
            col: -1
        }, ];

    function getValue(row, col) {
        return (1 << row) - col;
    }

    function hash(row, col, cols) {
        return row * cols + col;
    }

    function inRange(value, border) {
        return 0 <= value && value < border;
    }

    while (true) {
        if (used[hash(row, col, cols)]) {
            //console.log('Sadly the horse is doomed in ' + jumps + ' jumps');
        }
        if (!inRange(row, rows) || !inRange(col, cols)) {
            return 'Go go Horsy! Collected ' + sum + ' weeds';
        }

        var dirIndex = field[row][col],
            dir = directions[dirIndex];

        row += dir.row;
        col += dir.col;

    }
}

solve([
  '3 5',
  '54361',
  '43326',
  '52188',
]);

solve([
  '3 5',
  '54561',
  '43328',
  '52388',
]);
