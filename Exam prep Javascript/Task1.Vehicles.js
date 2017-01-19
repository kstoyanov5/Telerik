function solve(args) {
    var s = args[0];
    let count = 0;

    subSet([3,4,10], s);
    function subSet(numbers, target, partial) {
        var sum, n ,remaining;

        partial = partial || [];

        sum = partial.reduce(function (a, b) {
            return a + b;
        }, 0);

        if (sum === target) {
            count += 1;
        }

        if (sum >= target) {
            return;
        }

        for (var i = 0; i < numbers.length; i++) {
            n = numbers[i];
            remaining = numbers.slice(i + 1);
            subSet(remaining, target, partial.concat([n]));
        }
    }
    console.log(count);
}

solve([40]);