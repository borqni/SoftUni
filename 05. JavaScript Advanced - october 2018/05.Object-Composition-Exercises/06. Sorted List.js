function sortedList() {
    let list = (function() {
        let collection = [];

        let collectionProcessor = {
            add: function(element) {
                collection.push(element);
                collection.sort(ascendingOrder);
                this.size++;
                return collection;
            },
            remove: function(index) {
                if (isValidIndex(index)) {
                    collection.splice(index, 1);
                    this.size--;
                    return collection;
                }
            },
            get: function(index) {
                if (isValidIndex(index)) {
                    return collection[index];
                }
            },
            size: 0
        };

        return collectionProcessor;

        function ascendingOrder(a, b) {
            return a - b;
        }

        function isValidIndex(index) {
            return index >= 0 && index < collection.length;
        }
    })();

    return list;
}