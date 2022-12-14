<template>
    <v-footer 
        dark
        fixed
        padless>

        <v-card
            class="flex"
            text
            tile>
            <v-card-title class="green darken-4">
                <strong class="subheading"> Get connected with us on social networks</strong>
                <v-spacer></v-spacer>
                <v-btn
                v-for="icon in icons"
                :key="icon"
                class="mx-3"
                dark
                icon>
                <v-icon size="24px">{{icon}}</v-icon>
                </v-btn>
            </v-card-title>

            <div>
            <v-card-actions class="grey darken-3 justify-center ">
                ©2018 - <strong> Universitas Riau </strong>
            </v-card-actions>
            </div>
         </v-card>
    </v-footer>
</template>

<script>
export default {
    data: () => ({
        icons:[
            'mdi-facebook',
            'mdi-twitter',
            'mdi-google-plus',
            'mdi-linkedin',
            'mdi-instagram'
        ]
    })
}
</script>

<style>
#v-card-action.grey.darken-4{
    justify-content: center;
}

.justify-center{
    justify-content: center;
}
</style>


