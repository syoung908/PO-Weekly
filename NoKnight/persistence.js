function additivePersistence(num) {
	let sum = 0;
	String(num).split('').forEach(i => {
  	sum += parseInt(i);
  });
  
  if (String(sum).length == 1) {
  	return 1;
  } else {
  	return 1 + additivePersistence(sum);
  }
}

function multiplicativePersistence(num) {
	let product = 1;
	String(num).split('').forEach(i => {
  	product *= parseInt(i);
  });
  
  if (String(product).length == 1) {
  	return 1;
  } else {
  	return 1 + multiplicativePersistence(product);
  }
}

console.log(additivePersistence(123456));
console.log(multiplicativePersistence(123456));