function ingExtractor(input) {
	let words = input.split(' ');
  let results = [];
  
  words.forEach(word => {
  	if(word.toLowerCase().endsWith('ing')) {
    	if(word.replace('ing', '').replace(/\W/g, '').length != 1) {
      	results.push(word);
      } 
    }
  });
  
  return results;
}

console.log(ingExtractor("coming bringing Letting sing"));
console.log(ingExtractor("zing went ring, ding wing SINk"));