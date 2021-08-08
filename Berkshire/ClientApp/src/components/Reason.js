import React from 'react';

function Reason(prop) {
  console.log("reason: ", prop.reason);
  const reason = prop.reason;
  return (
    <>
      <p>Test {reason.id} {reason.reason}</p>
    </>
  );
}

export default Reason;