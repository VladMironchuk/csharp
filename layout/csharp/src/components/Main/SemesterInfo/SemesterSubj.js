import "./SemesterSubj.css"

const SemesterSubj = props => {
  return (
    <div className="sem-container">
      <div>{props.name}</div>
      <div>{props.teacher}</div>
    </div>
  )
}

export default SemesterSubj;