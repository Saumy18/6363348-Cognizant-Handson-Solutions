import React from 'react';
import CohortDetails from './Components/CohortDetails';

function App() {
  const cohorts = [
    {
      name: 'INTADMDF10 -.NET FSD',
      status: 'Scheduled',
      startDate: '22-Feb-2022',
      coach: 'Aathma',
      trainer: 'Jojo Jose'
    },
    {
      name: 'ADM21JF014 -Java FSD',
      status: 'Ongoing',
      startDate: '10-Sep-2021',
      coach: 'Apoorv',
      trainer: 'Elisa Smith'
    },
    {
      name: 'CDBJF21025 -Java FSD',
      status: 'Ongoing',
      startDate: '24-Dec-2021',
      coach: 'Aathma',
      trainer: 'John Doe'
    }
  ];

  return (
    <div style={{ padding: '20px' }}>
      <h1>Cohorts Details</h1>
      {cohorts.map((cohort, index) => (
        <CohortDetails
          key={index}
          name={cohort.name}
          status={cohort.status}
          startDate={cohort.startDate}
          coach={cohort.coach}
          trainer={cohort.trainer}
        />
      ))}
    </div>
  );
}

export default App;
