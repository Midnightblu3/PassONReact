import { useEffect, useState } from "react";

const App = () => {

    const [items, setItems] = useState([])
    useEffect(() => {
        fetch("api/item/GetItems")
            .then(response => { return response.json() })
            .then(responseJson => {
                setItems(responseJson)})
    }, [])
    return (<div className="container">
        <h1>Items</h1>
        <div className="row">
            <div className="col-sm-12">
                <table className="table table-striped">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Name</th>
                            <th>ShortDescription</th>
                            <th>LongDescription</th>
                            <th>Price</th>
                            <th>IsPromoted</th>
                            <th>Category</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            items.map((item) => (
                                <tr>
                                    <td>{ item.id}</td>
                                    <td>{item.name }</td>
                                    <td>{item.shortDescription }</td>
                                    <td>{item.longDescription }</td>
                                    <td>{item.price}</td>
                                    <td>{item.isPromoted}</td>
                                    <td>{item.categoryId }</td>
                                </tr>
                             ))
                        }
                    </tbody>
                </table>
            </div>
        </div>
    </div>)
}

export default App;