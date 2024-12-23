"use client";
import { createContext, useContext, useState } from "react";
import { jwtDecode } from "jwt-decode";
import { useEffect } from "react";
import { useRouter } from 'next/navigation';

export const RealTimeContext = createContext(null);

export const RealTimeProvider = ({ children }) => {
    const [connection, setConnection] = useState(null);

    return (
        <RealTimeContext.Provider value={{ connection, setConnection }}>
            {children}
        </RealTimeContext.Provider>
    );
};
