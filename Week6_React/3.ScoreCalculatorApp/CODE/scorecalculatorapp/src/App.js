import { CalculateScore } from './Components/CalculateScore';

function App() {
  return (
    <div>
      <CalculateScore 
        Name={"Saumy Raj"} 
        School={"Kalinga Institute of Industrial Technology"} 
        total={284} 
        goal={3} 
      />
    </div>
  );
}

export default App;
