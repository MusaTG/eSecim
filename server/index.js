const express = require('express')
const {spawn} = require('child_process');
const app = express()
const port = 3000
app.use(express.json());
app.get('/', (req, res) => {
	
	 var dataToSend;
	 // spawn new child process to call the python script
	 const python = spawn('python', ['script.py','Help']);
	 // collect data from script
	 python.stdout.on('data', function (data) {
	  console.log('Pipe data from python script ...');
	  dataToSend = data.toString();
	 });
	 // in close event we are sure that stream from child process is closed
	 python.on('close', (code) => {
	 console.log(`child process close all stdio with code ${code}`);
	 // send data to browser
	 res.send(dataToSend)
	});
})
app.get('/dilKontrol', function (req, res) {
	 var dataToSend;
	 // spawn new child process to call the python script
	 const python = spawn('python', ['script.py','dilKontrol',req.query.method,req.query.text]);
	 //const python = spawn('python', ['script.py']);
	 // collect data from script
	 python.stdout.on('data', function (data) {
	  console.log('Pipe data from python script ...');
	  dataToSend = data.toString();
	 });
	 // in close event we are sure that stream from child process is closed
	 python.on('close', (code) => {
	 console.log(`child process close all stdio with code ${code}`);
	 // send data to browser
	 res.send(dataToSend)
	});
})
app.get('/sifrelemeYontemleri', function (req, res) {
	 var dataToSend;
	 // spawn new child process to call the python script
	 const python = spawn('python', ['script.py','sifrelemeYontemleri',req.query.method,req.query.text,req.query.key]);
	 //const python = spawn('python', ['script.py']);
	 // collect data from script
	 python.stdout.on('data', function (data) {
	  console.log('Pipe data from python script ...');
	  dataToSend = data.toString();
	 });
	 // in close event we are sure that stream from child process is closed
	 python.on('close', (code) => {
	 console.log(`child process close all stdio with code ${code}`);
	 // send data to browser
	 res.send(dataToSend)
	});
})
app.get('/Help', function (req, res) {
	 var dataToSend;
	 // spawn new child process to call the python script
	 const python = spawn('python', ['script.py','Help']);
	 //const python = spawn('python', ['script.py']);
	 // collect data from script
	 python.stdout.on('data', function (data) {
	  console.log('Pipe data from python script ...');
	  dataToSend = data.toString();
	 });
	 // in close event we are sure that stream from child process is closed
	 python.on('close', (code) => {
	 console.log(`child process close all stdio with code ${code}`);
	 // send data to browser
	 res.send(dataToSend)
	});
})
app.listen(port, () => console.log(`Example app listening on port 
${port}!`))