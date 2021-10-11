import Navbar from "./Navbar/Navbar";
import facultyInfo from "../../store/univerInfo";
import {useState} from "react";
import SemesterInfo from "./SemesterInfo/SemesterInfo";
import "./Main.css"

const Main = () => {

  const [courseInfo, setCourseInfo] = useState(facultyInfo["first_course"]);

  const changeInfoHandler = course => {
    setCourseInfo(facultyInfo[course])
  }

  return (
    <>
      <Navbar onChangeInfo={changeInfoHandler}/>
      <div className="course">
        <SemesterInfo sem={courseInfo.autumn}/>
        <SemesterInfo sem={courseInfo.spring}/>
      </div>
    </>
  )
}

export default Main;