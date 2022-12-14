<template>
    <v-toolbar class="flex-grow-0" color="green darken-4" dark>
    <v-app-bar-nav-icon @click.stop="drawer = !drawer"></v-app-bar-nav-icon>
        <router-link style="text.decoration: none; color: inherit;" to="/Home">
        <v-btn text href="WebHome.vue">Home</v-btn>
        </router-link>
        <v-btn text>Profile</v-btn>
        <v-btn text>Unit/Lembaga</v-btn>
        <v-btn text>Akademik</v-btn>
        <v-btn text>Dokumen</v-btn>
        <v-btn text>Gallery</v-btn>
        <v-btn text>Peta</v-btn>
        <v-btn text>Video Profil</v-btn>
        <router-link style="text.decoration: none; color: inherit;" to="/Login">
            <v-btn text href="WebLogin.vue">Kontak</v-btn>
        </router-link>
    
    <div class="hidden-sm-and-down">
        <v-navigation-drawer
        v-model="drawer"
        absolute
        temporary
        height="800px">
        <v-list class="px-1">
                <v-list-tile-avatar>
                    <v-img src="https://randomuser.me/api/portraits/men/85.jpg" style="display:block"></v-img>
                </v-list-tile-avatar>
                <v-list-item-content>
                <v-list-tile-title>John Leider</v-list-tile-title>
                </v-list-item-content>
        </v-list>
        <v-list class="pt-0" dense>
            <v-divider></v-divider>
            <v-list-tile
            v-for="item in items"
            :key="item.title"
            link>
            <div>
            <v-list-tile-action>
                <v-icon>{{item.icon}}</v-icon>
            </v-list-tile-action>
            <v-list-tile-action>
                <v-list-tile-title>{{item.title}}</v-list-tile-title>
            </v-list-tile-action>
            </div>
            </v-list-tile>
        </v-list>
        </v-navigation-drawer>
    </div>
    </v-toolbar>
</template>

<script>
export default {
    data(){
        return{
            drawer: false,
            items: [
                { title: 'Home',icon: 'mdi-home'},
                { title: 'About', icon: 'mdi-information-outline'}
            ]
        }
    }
}
</script>
