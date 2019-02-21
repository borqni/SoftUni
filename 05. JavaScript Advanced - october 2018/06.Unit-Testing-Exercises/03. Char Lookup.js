let expect = require('chai').expect;

function lookupChar(string, index) {
    if (typeof(string) !== 'string' || !Number.isInteger(index)) {
        return undefined;
    }
    if (string.length <= index || index < 0) {
        return 'Incorrect index';
    }
    return string.charAt(index);
}

describe('lookupChar Unit Tests', function () {
    describe('Undefined tests', function () {
        it('Pass an object(should return undefined)', function () {
            let result = lookupChar({}, 5);
            expect(result).to.be.undefined;
        });
        it('Pass floating point number(should return undefined)', function () {
            let result = lookupChar('asdf', 1.5);
            expect(result).to.be.undefined;
        });
    });

    describe('Incorrect index tests', function () {
        it('Pass a negative number(should return incorrect index)', function () {
            let result = lookupChar('str', -5);
            expect(result).to.be.equal('Incorrect index');
        });
        it('Pass a bigger index(should return incorrect index)', function () {
            let result = lookupChar('str', 15);
            expect(result).to.be.equal('Incorrect index');
        });
    });

    describe('Index correct tests', function () {
        it('Pass correct parameters(should return correct symbol at index)', function () {
            let result = lookupChar('pesho', 0);
            expect(result).to.be.equal('p');
        });
        it('Pass a bigger index(should return incorrect index)', function () {
            let result = lookupChar('gosho', 4);
            expect(result).to.be.equal('o');
        });
    })
});