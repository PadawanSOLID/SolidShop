import axios from "axios";

const httpInstance=axios.create({
    baseURL:'http://localhost:5200/api',
    timeout:5000
})
httpInstance.interceptors.request.use(config=>{
    return config
},e=>Promise.reject(e))
httpInstance.interceptors.response.use(res=>{
    return res.data
},e=>Promise.reject(e))
export default httpInstance