function solve(args) {
    let s = args[0];
    let c1 = args[1];
    let c2 = args[2];
    let c3 = args[3];

    let answer = 0;
    let price = 0;

    for (var i = 0; i <= s / c1 + 1; i += 1) {
        for (var j = 0; j <= s / c2 + 1; j+= 1) {
            for (var k = 0; k <= s / c3 + 1; k+= 1) {
                price = i * c1 + j * c2 + k * c3;
                if (price <= s) {
                    answer = Math.max(answer, price);
                }
            }
        }
    }
    console.log(answer);
}

solve([
    20,
    11,
    200,
    300]);