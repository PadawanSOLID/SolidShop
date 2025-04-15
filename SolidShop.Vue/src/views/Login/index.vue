<template>
    <div>
        <header class="login-header">
            <div class="container m-top-20">
                <h1 class="logo">
                    <RouterLink to="/">小兔鲜</RouterLink>
                </h1>
                <RouterLink class="entry" to="/">
                    <i class="iconfont icon-angle-right"></i>
                    <i class="iconfont icon-angle-right"></i>
                </RouterLink>
            </div>
        </header>
        <section class="login-section">
            <div class="wrapper">
                <nav>
                    <a href="#">账户登录</a>
                </nav>
                <div class="account-box">
                    <div class="form">
                        <el-form ref="formRef" :model="form" :rules="rules" label-width="60px" status-icon>
                            <el-form-item prop="account" label="账户">
                                <el-input type="text" v-model="form.account" />
                            </el-form-item>
                            <el-form-item prop="password" label="密码">
                                <el-input type="password" v-model="form.password" />
                            </el-form-item>
                            <el-form-item label-width="22px" prop="agree">
                                <el-checkbox v-model="form.agree" size="large">我已同意隐私条款</el-checkbox>
                            </el-form-item>
                            <el-button size="large" class="subBtn" @click="doLogin">点击登录</el-button>
                        </el-form>
                    </div>
                </div>
            </div>
        </section>
        <footer class="login-footer">
            <div class="container">
                <p>
                    <a href="#">关于我们</a>
                    <a href="#">帮助中心</a>
                    <a href="#">售后服务</a>
                    <a href="#">配送与验收</a>
                    <a href="#">商务合作</a>
                    <a href="#">搜索推荐</a>
                    <a href="#">友情链接</a>
                </p>
                <p>CopyRight &copy; 小兔鲜儿</p>
            </div>
        </footer>
    </div>
</template>

<script setup>
import { ref } from 'vue';
import { ElMessage } from 'element-plus';
import 'element-plus/theme-chalk/el-message.css'
import { useRouter } from 'vue-router';
import { useUserStore } from '@/stores/user';
const router = useRouter()
const form = ref({
    account: '',
    password: '',
    agree: true
})
const formRef = ref(null)
const userStore = useUserStore()
const doLogin = () => {
    formRef.value.validate(async (valid) => {
        if (valid) {
            await userStore.getUserInfo(form.value)
            ElMessage({ type: 'success', message: '登录成功' })
            router.replace({ path: '/' })
        }
    })
}
const rules = {
    account: [
        { required: true, message: '用户名不能为空', trigger: 'blur' }
    ],
    password: [
        { required: true, message: '密码不能为空', trigger: 'blur' },
        { min: 6, max: 14, message: '密码不能为空', trigger: 'blur' }
    ],
    agree: [
        {
            validator: (rule, value, callback) => {
                console.log(value)
                if (value) {
                    callback()
                }
                else {
                    callback(new Error('请勾选协议'))
                }
            }
        }
    ]
}
</script>

<style lang="scss" scoped>
.login-header {
    background: #fff;
    border-bottom: 1px solid #e4e4e4;

    .container {
        display: flex;
        align-items: flex-end;
        justify-content: space-between;
    }

    .logo {
        width: 200px;

        a {
            display: block;
            height: 132px;
            width: 100%;
            text-indent: -9999px;
            background: url(@/assets/images/logo.jpg) no-repeat center 18px /contain;
        }
    }
}

.code {
    position: absolute;
    right: 1px;
    top: 1px;
    text-align: center;
    line-height: 34px;
    font-size: 14px;
    background: #f5f5f5;
    color: #fff;
    width: 90px;
    height: 34px;
    cursor: pointer;
}

.entry {
    width: 120px;
    margin-bottom: 38px;
    font-size: 16px;

    i {
        font-size: 14px;
        color: $xtxColor;
        letter-spacing: -5px;
    }
}

.login-section {
    background: url('@/assets/images/logo.jpg') no-repeat center /cover;
    height: 488px;
    position: relative;

    .wrapper {
        width: 380px;
        background: #fff;
        position: absolute;
        left: 50%;
        top: 54px;
        transform: translate3d(100px, 0, 0);
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.15);

        nav {
            font-size: 14px;
            height: 55px;
            margin-bottom: 20px;
            border-bottom: 1px solid #f5f5f5;
            display: flex;
            padding: 0 40px;
            text-align: right;
            align-items: center;
        }
    }
}

.input {
    position: relative;
    height: 36px;
    width: 100px;

    >i {
        width: 34px;
        height: 34px;
        background: #cfcdcd;
        color: #fff;
        position: absolute;
        left: 1px;
        top: 1px;
        text-align: center;
        line-height: 34px;
        font-size: 18px;

    }

    input {
        padding-left: 44px;
        border: 1px solid #cfcdcd;
        height: 36px;
        line-height: 36px;
        width: 100%;

        &.error {
            border-color: $priceColor;
        }
    }
}

.action {
    padding: 20px 40px;
    display: flex;
    justify-content: space-between;
    align-items: center;

    .url {
        a {
            color: #999;
            margin-left: 10px;
        }
    }
}

.subBtn {
    background: $xtxColor;
    width: 100%;
    color: #fff;
}
</style>