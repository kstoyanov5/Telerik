function solve(args) {
    'use strict';
    let numsCount = +args[0];

    let result = +args[1];
    let modulo = 1024;
    result = result % modulo;
    let nums = args.slice(1, args.length - 1).map(Number);

    for (var i = 0; i <= nums.length - 1;) {

        if (nums[i] % 2 === 0) {
            result = result + (nums[i]);
            result = result % modulo;

            if (i + 2 > numsCount) {
                break;
            }
            else {
                i = i+2;
            }
        }
        else {
            result = result * (nums[i]);
            result = result % modulo;

            if (i + 1 > numsCount) {
                break;
            }
            else {
                i = i+1;
            }
        }
    }
    console.log(result);
}

solve([  '9',
  '9',
  '9',
  '9',
  '9',
  '9',
  '9',
  '9',
  '9',
  '9'
]);

solve([  '10',
  '1',
  '2',
  '3',
  '4',
  '5',
  '6',
  '7',
  '8',
  '9',
  '0'
])