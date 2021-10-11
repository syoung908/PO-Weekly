const products = {
	1: ["Something", 100],
	7: ["Crackers", 120]
};

const coins = [500, 200, 100, 50, 20, 10];

function vendingMachine(p, money, productNum) {
	let change = [];
  
  let changeAmount = 0;
  try {
  	changeAmount = money - p[productNum][1];
  } catch (exception) {
  	return "Enter a valid product number"
  }
  
  if (changeAmount < 0) return "Not enough money for this product";
  
  coins.forEach(coin => {
  	while(changeAmount >= coin) {
    	change.push(coin);
      changeAmount -= coin;
    }
  });
  
  return {
  	product: p[productNum][0],
    change: change
  }
}

console.log(vendingMachine(products, 200, 7));
console.log(vendingMachine(products, 500, 0));
console.log(vendingMachine(products, 90, 1));