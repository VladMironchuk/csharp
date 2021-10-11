import SemesterSubj from "./SemesterSubj";
import "./SemesterInfo.css"

const SemesterInfo = props => {
  return (
    <div className="sem">
      <h2 className="season">
        {props.sem.semester % 2 === 1 ? "Осень" : "Весна"}
        <span className="text-muted">
          <small>Семестр {props.sem.semester}</small>
        </span>
      </h2>
      <ul className="list-group">
        {props.sem.subjects.map(subject => (
          <SemesterSubj
            key={Math.random().toString()}
            name={subject.name}
            teacher={subject.teacher}
          />
        ))}
      </ul>
    </div>
  )
}

export default SemesterInfo