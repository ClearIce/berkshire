import React from 'react';

function Reason(prop) {
  const reason = prop.reason;
  return (
    <li>
      {reason.reason}
    </li>
  );
}

export default Reason;