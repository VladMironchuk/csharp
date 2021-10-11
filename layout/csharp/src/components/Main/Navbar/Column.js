const Column = ({name, onClick}) => {
  return (
    <div onClick={onClick} className="col">
      {name}
    </div>
  )
}

export default Column