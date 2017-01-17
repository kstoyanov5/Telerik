function solve(args) {
    "use strict";
    let numbers = args[0].split(' ').map(Number);
    let sum = 0;
    for (var i = 2; i < numbers.length - 2; i+=1) {
        if (isPocket(i, numbers)) {
            sum = sum + numbers[i];
        }
    }
    console.log(sum);

    function isPocket(index, heights) {
        return isValley(index, heights) && isPeak(index - 1, heights) && isPeak(index + 1, heights);
    }

    function isValley(index, valley) {
        return valley[index] < valley[index - 1] &&
            valley[index] < valley[index + 1];
    }

    function isPeak(index, valley) {
        return valley[index] > valley[index - 1] &&
            valley[index] > valley[index + 1];
    }
}
