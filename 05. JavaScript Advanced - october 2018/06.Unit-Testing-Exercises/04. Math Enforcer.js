let expect = require('chai').expect;

let mathEnforcer = {
    addFive: function (num) {
        if (typeof(num) !== 'number') {

            return undefined;
        }
        return num + 5;
    },
    subtractTen: function (num) {
        if (typeof(num) !== 'number') {
            return undefined;
        }
        return num - 10;
    },
    sum: function (num1, num2) {
        if (typeof(num1) !== 'number' || typeof(num2) !== 'number') {
            return undefined;
        }
        return num1 + num2;
    }
};

describe('Math enforcer unit tests', function () {
    describe('addFive', function () {
        it('with a string(shout return undefined)', function () {
            let result = mathEnforcer.addFive('string');
            expect(result).to.be.undefined;
        });
        it('with an object(shout return undefined)', function () {
            let result = mathEnforcer.addFive({});
            expect(result).to.be.undefined;
        });
        it('with positive number(shout return number+5)', function () {
            let result = mathEnforcer.addFive(5);
            expect(result).to.be.equal(10);
        });
        it('with negative number(shout return number+5)', function () {
            let result = mathEnforcer.addFive(-5);
            expect(result).to.be.equal(0);
        });
        it('with floating point number(shout return number+5)', function () {
            let result = mathEnforcer.addFive(1.5);
            expect(result).to.be.closeTo(6.5, 0.01); // закръгляне при дробни числа
        });
    });

    describe('subtractTen', function () {
        it('with a string(shout return undefined)', function () {
            let result = mathEnforcer.subtractTen('string');
            expect(result).to.be.undefined;
        });
        it('with positive number(shout return number -10)', function () {
            let result = mathEnforcer.subtractTen(15);
            expect(result).to.be.equal(5);
        });
        it('with negative number(shout return number -10)', function () {
            let result = mathEnforcer.subtractTen(-15);
            expect(result).to.be.equal(-25);
        });
        it('with floating point number(shout return number-10)', function () {
            let result = mathEnforcer.subtractTen(15.15);
            expect(result).to.be.closeTo(5.15, 0.01); // закръгляне при дробни числа
        });
    });

    describe('sum', function () {
        it('first parameter is string(shout return undefined)', function () {
            let result = mathEnforcer.sum('string', 10);
            expect(result).to.be.undefined;
        });
        it('second parameter is string(shout return undefined)', function () {
            let result = mathEnforcer.sum(10, 'string');
            expect(result).to.be.undefined;
        });
        it('first parameter is undefined(shout return undefined)', function () {
            let result = mathEnforcer.sum(undefined, 10);
            expect(result).to.be.undefined;
        });
        it('second parameter is undefined(shout return undefined)', function () {
            let result = mathEnforcer.sum(10, undefined);
            expect(result).to.be.undefined;
        });
        it('with two positive numbers(shout return the sum)', function () {
            let result = mathEnforcer.sum(10, 5);
            expect(result).to.be.equal(15);
        });
        it('with two negative numbers(shout return the sum)', function () {
            let result = mathEnforcer.sum(-10, -5);
            expect(result).to.be.equal(-15);
        });
        it('with two floating points numbers(shout return the sum)', function () {
            let result = mathEnforcer.sum(1.51, 5.21);
            expect(result).to.be.closeTo(6.72, 0.01);
        });
    })
});
