
import { createApp } from 'vue'
import App from './App.vue'
import { createPinia } from 'pinia'
import router from './router';
import './styles/common.scss'
import { lazyPlugin } from './directives';
const pinia = createPinia();
const app = createApp(App)
app.use(pinia)
app.use(router)
app.use(lazyPlugin)
app.mount('#app')


