import "./Navbar.css"
import Column from "./Column";

const Navbar = ({onChangeInfo}) => {
  return (
    <div className="container">
      <div className="row">
        <Column onClick={onChangeInfo.bind(null, "first_course")} name="1 курс"/>
        <Column onClick={onChangeInfo.bind(null, "second_course")} name="2 курс"/>
        <Column onClick={onChangeInfo.bind(null, "third_course")} name="3 курс"/>
        <Column onClick={onChangeInfo.bind(null, "fourth_course")} name="4 курс"/>
        <Column onClick={onChangeInfo.bind(null, "first_mag_course")} name="Маг 1 курс"/>
        <Column onClick={onChangeInfo.bind(null, "second_mag_course")} name="Маг 2 курс"/>
      </div>
    </div>
  )
}

export default Navbar;