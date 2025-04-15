import ImageView from './ImageView/index.vue'


export const componentPlugin = {
    install(app) {
        app.component('XtxImageView', ImageView)
    }
}