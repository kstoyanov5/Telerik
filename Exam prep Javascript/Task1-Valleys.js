function solve(args) {
    let numbers = args[0].split(' ').map(Number);

    function isPeak(index) {
        if (index === 0 || index === numbers.length - 1) {
            return true;
        }
        if (numbers[index] > numbers[index - 1]
            && numbers[index] > numbers[index + 1]) {
            return true;
        }
        return false;
    }

    let peaks = [];
    numbers.forEach(function(number, ind) {
        if (isPeak(ind)) {
            peaks.push(ind);
        }
    });
    let maxSum = 0;
    for(let i = 1; i < peaks.length; i+=1) {
        let startIndex = peaks[i - 1];
        let endIndex = peaks[i];
        let result = 0;
        for (let j = startIndex; j <= endIndex; j++) {
            result += numbers[j];
        }
        if (maxSum < result) {
            maxSum = result;
        }
    }

console.log(maxSum);
}

solve([
    "5 1 7 4 8"
    ]);

solve([
    "5 1 7 6 5 6 4 2 3 8"
    ]);
