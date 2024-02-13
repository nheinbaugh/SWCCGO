import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import { HubConnectionBuilder } from '@microsoft/signalr';

// import * as signalR from '@microsoft/signalr';

const connection = new HubConnectionBuilder().withUrl("http://localhost:5266/game").build();

connection.start();

connection.on("broadcastMessage", (user, message) => {
  console.log("Message Received: ", message, user);
});

function sendMessage(name: string, message: string) {
  connection.send("send", name, message);
}

function App() {
  const [count, setCount] = useState(0);
  const [message, setMessage] = useState<string>('');
  const [name, setName] = useState<string>('');

  const handleSendMessage = () => {
    sendMessage("Test", "Hello World");
  }

  return (
    <>
      <div>
        <a href="https://vitejs.dev" target="_blank">
          <img src={viteLogo} className="logo" alt="Vite logo" />
        </a>
        <a href="https://react.dev" target="_blank">
          <img src={reactLogo} className="logo react" alt="React logo" />
        </a>
      </div>
      <h1>Vite + React</h1>
      <div className="card">
        <button onClick={() => setCount((count) => count + 1)}>
          count is {count}
        </button>
        <p>
          Edit <code>src/App.tsx</code> and save to test HMR
        </p>
      </div>
      <input type="text" onChange={e => setName(e.target.value)} />
      <input type="text" onChange={e => setMessage(e.target.value)} />
      <button onClick={handleSendMessage}>Send Message</button>

      <div>
        <p>{name}</p>
        <p>{message}</p>
      </div>
      <p className="read-the-docs">
        Click on the Vite and React logos to learn more
      </p>
    </>
  )
}

export default App
