function solve(arr, criteria) {
    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = +price;
            this.status = status;
        }
    }

    let ticketes = [];
    for (let line of arr) {
        let [destination, price, status] = line.split("|");
        let ticket = new Ticket(destination, price, status);
        ticketes.push(ticket);
    }

    return ticketes.sort((a, b) => a[criteria] > b[criteria]);
}

console.log(solve(['Philadelphia|94.20|available',
        'New York City|95.99|available',
        'New York City|95.99|sold',
        'Boston|126.20|departed'],
    'destination')

)